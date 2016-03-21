namespace AircraftShooter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Audio;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.GamerServices;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using Microsoft.Xna.Framework.Media;

    public class GameAircraftShooter : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        InputManager inputManager;
        SpriteFont font;

        Texture2D mainBackground;
        Texture2D enemyTextureOne;
        Texture2D enemyTextureTwo;
        Texture2D playerBulletTexture;
        Texture2D enemyBulletTexture;
        Texture2D explosionTexture;

        ParallaxingBackground bgLayerOne;
        ParallaxingBackground bgLayerTwo;
        Player player;
        Animation rotor;
        List<Enemy> enemies;
        List<Animation> explosions;

        SoundEffect bulletSound;
        SoundEffect explosionSound;
        Song gameplayMusic;

        TimeSpan enemySpawnTime;
        TimeSpan previousSpawnTime;
        TimeSpan enemyFireTime;
        TimeSpan previosEnemyFireTime;
        Random random;

        //Texture2D pixel;

        public GameAircraftShooter()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 600;
            graphics.PreferredBackBufferHeight = 700;
            graphics.PreferMultiSampling = false;
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            inputManager = new InputManager();
            player = new Player();
            rotor = new Animation();
            enemies = new List<Enemy>();
            explosions = new List<Animation>();
            bgLayerOne = new ParallaxingBackground();
            bgLayerTwo = new ParallaxingBackground();
            random = new Random();

            previousSpawnTime = TimeSpan.Zero;
            enemySpawnTime = TimeSpan.FromSeconds(2.0f);
            enemyFireTime = TimeSpan.FromSeconds(1.5f);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //pixel = new Texture2D(GraphicsDevice, 1, 1);
            //pixel.SetData(new[] { Color.White });

            font = Content.Load<SpriteFont>("Fonts\\SegoeUIMono");
            mainBackground = Content.Load<Texture2D>("Sprites\\Grass_background");
            bgLayerOne.Initialize(Content, "Sprites\\Yellowclouds_background", GraphicsDevice.Viewport.Height, 1);
            bgLayerTwo.Initialize(Content, "Sprites\\Blueclouds_background", GraphicsDevice.Viewport.Height, 5);
            enemyTextureOne = Content.Load<Texture2D>("Sprites\\Aircraft_02");
            enemyTextureTwo = Content.Load<Texture2D>("Sprites\\Aircraft_05");
            playerBulletTexture = Content.Load<Texture2D>("Sprites\\bullet_2_blue");
            enemyBulletTexture = Content.Load<Texture2D>("Sprites\\bullet_2_orange");
            explosionTexture = Content.Load<Texture2D>("Sprites\\Explosion");
            Vector2 playerPosition = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.Width / 2, GraphicsDevice.Viewport.TitleSafeArea.Bottom);
            player.Initialize(Content.Load<Texture2D>("Sprites\\Aircraft_10"), playerPosition, GraphicsDevice.Viewport);
            Vector2 rotorPosition = new Vector2((player.Position.X + player.Width / 2), (player.Position.Y - player.Height + 10));
            rotor.Initialize(Content.Load<Texture2D>("Sprites\\Rotor_animation"), rotorPosition, 8, 20, 1f, true);

            bulletSound = Content.Load<SoundEffect>("Sounds\\Loud_Gunshot");
            explosionSound = Content.Load<SoundEffect>("Sounds\\Explosion");
            gameplayMusic = Content.Load<Song>("Sounds\\GameMusic");
            PlayMusic(gameplayMusic);
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (inputManager.KeyDown(Keys.Escape))
                this.Exit();

            inputManager.Update();
            UpdatePlayer(gameTime);
            UpdateRotor(gameTime);
            UpdateEnemies(gameTime);
            UpdateProjectiles();
            UpdateEnemyProjectiles();
            UpdateCollisions();
            UpdateExpolsions(gameTime);
            bgLayerOne.Update();
            bgLayerTwo.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(mainBackground, Vector2.Zero, Color.White);
            bgLayerOne.Draw(spriteBatch);
            player.Draw(spriteBatch); //spriteBatch.Draw(pixel, player.Rectangle, Color.Snow);
            
            foreach (var enemy in enemies)
            {
                enemy.Draw(spriteBatch); //spriteBatch.Draw(pixel, enemy.BoundingBox, Color.SkyBlue);
                foreach (var bullet in enemy.Projectiles)
                {
                    bullet.Draw(spriteBatch);
                }
            }
            foreach (var projectile in player.Projectiles)
            {
                projectile.Draw(spriteBatch, SpriteEffects.None);
            }
            foreach (var explosion in explosions)
            {
                explosion.Draw(spriteBatch);
            }
            
            bgLayerTwo.Draw(spriteBatch);
            rotor.Draw(spriteBatch);
            spriteBatch.DrawString(font, "Scores: " + player.Score, 
                new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X, GraphicsDevice.Viewport.TitleSafeArea.Y), Color.White);
            spriteBatch.DrawString(font, "Health: " + player.Health,
                new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X, GraphicsDevice.Viewport.TitleSafeArea.Y + 30), Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        private void UpdatePlayer(GameTime gameTime)
        {
            player.Update(gameTime, inputManager);

            if (inputManager.KeyDown(Keys.Space))
            {
                AddPlayerProjectile(new Vector2(player.Position.X - 4 + player.Width / 2, player.Position.Y));
                bulletSound.Play();               
            }

            if (player.Health <= 0)
            {
                player.Health = 100;
                player.Score = 0;
            }
        }

        private void UpdateCollisions()
        {
            player.BoundingRectangle = new Rectangle((int)player.Position.X, (int)player.Position.Y, player.Width, player.Height);
            UpdateEnemyBulletColision();
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].BoundingRectangle = new Rectangle((int)enemies[i].Position.X, (int)enemies[i].Position.Y, enemies[i].Width, enemies[i].Height);
                if (player.BoundingRectangle.Intersects(enemies[i].BoundingRectangle))
                {
                    player.Health -= enemies[i].Damage;
                    enemies[i].Health = 0;
                    if (player.Health <= 0)
                    {
                        player.IsAlive = false;
                    }
                }

                for (int j = 0; j < player.Projectiles.Count; j++)
                {
                    player.Projectiles[j].BoundingRectangle = new Rectangle((int)player.Projectiles[j].Position.X, (int)player.Projectiles[j].Position.Y,
                        player.Projectiles[j].Width, player.Projectiles[j].Height);
                    if (player.Projectiles[j].BoundingRectangle.Intersects(enemies[i].BoundingRectangle))
                    {
                        enemies[i].Health -= player.Projectiles[j].Damage;
                        player.Projectiles[j].IsActive = false;
                    }
                }
            }
        }

        private void UpdateEnemyBulletColision()
        {
            foreach (var enemy in enemies)
            {
                for (int i = 0; i < enemy.Projectiles.Count; i++)
                {
                    enemy.Projectiles[i].BoundingRectangle = new Rectangle((int)enemy.Projectiles[i].Position.X, (int)enemy.Projectiles[i].Position.Y,
                                                                    enemy.Projectiles[i].Width, enemy.Projectiles[i].Height);
                    if (player.BoundingRectangle.Intersects(enemy.Projectiles[i].BoundingRectangle))
                    {
                        player.Health -= enemy.Projectiles[i].Damage;
                        explosionSound.Play();
                        enemy.Projectiles[i].IsActive = false;
                    }
                }
            }
        }

        private void UpdateRotor(GameTime gameTime)
        {
            rotor.Position = new Vector2((player.Position.X + player.Width / 2), (player.Position.Y + 10));
            rotor.Update(gameTime);
        }

        private void UpdateProjectiles()
        {
            for (int i = player.Projectiles.Count - 1; i >= 0; i--)
            {
                player.Projectiles[i].UpdateUp();
                if (player.Projectiles[i].IsActive == false)
                {
                    player.Projectiles.RemoveAt(i);
                }
            }
        }

        private void UpdateEnemyProjectiles()
        {
            foreach (var enemy in enemies)
            {
                for (int i = enemy.Projectiles.Count - 1; i >= 0; i--)
                {
                    enemy.Projectiles[i].UpdateDown();
                    if (enemy.Projectiles[i].IsActive == false)
                    {
                        enemy.Projectiles.RemoveAt(i);
                    }
                }
            }
        }

        private void AddPlayerProjectile(Vector2 position)
        {
            Projectile bullet = new Projectile();
            bullet.Initialize(GraphicsDevice.Viewport, playerBulletTexture, position);
            player.Projectiles.Add(bullet);
        }

        private void AddEnemyProjectile(Enemy enemy, Vector2 position)
        {
            Projectile bullet = new Projectile();
            bullet.Initialize(GraphicsDevice.Viewport, enemyBulletTexture, position);
            bullet.Velocity.Y = 7f;
            enemy.Projectiles.Add(bullet);
        }

        private void AddEnemy()
        {
            int spawn = random.Next(1, 10);
            Enemy enemy = new Enemy();
            if (spawn % 2 == 0)
            {
                var positionFirst = new Vector2(random.Next(50, GraphicsDevice.Viewport.Width - enemyTextureOne.Width), 
                    -enemyTextureOne.Height);
                enemy.Initialize(GraphicsDevice.Viewport, enemyTextureOne, positionFirst);
                enemies.Add(enemy);
            }
            else
            {
                var positionSecond = new Vector2(random.Next(50, GraphicsDevice.Viewport.Width - enemyTextureTwo.Width),
                    -enemyTextureTwo.Height * 2);
                enemy.Initialize(GraphicsDevice.Viewport, enemyTextureTwo, positionSecond);
                enemies.Add(enemy);
            }
        }

        private void AddExplosion(Vector2 position)
        {
            Animation explosion = new Animation();
            explosion.Initialize(explosionTexture, position, 12, 20, 1f, false);
            explosions.Add(explosion);
        }

        private void UpdateEnemies(GameTime gameTime)
        {
            if (gameTime.TotalGameTime - previousSpawnTime > enemySpawnTime)
            {
                previousSpawnTime = gameTime.TotalGameTime;
                AddEnemy();
            }

            for (int i = enemies.Count - 1; i >= 0; i--)
            {
                enemies[i].Update();

                if (enemies[i].IsAlive == false)
                {
                    if (enemies[i].Health <= 0)
                    {
                        AddExplosion(enemies[i].Position + new Vector2(enemies[i].Width / 2, enemies[i].Height / 2));
                        explosionSound.Play();
                        player.Score += enemies[i].Value;
                    }
                    enemies.RemoveAt(i);
                }

                if (gameTime.TotalGameTime - previosEnemyFireTime > enemyFireTime)
                {
                    previosEnemyFireTime = gameTime.TotalGameTime;
                    AddEnemyProjectile(enemies[i], new Vector2(enemies[i].Position.X + 20, enemies[i].Position.Y + 2));
                    AddEnemyProjectile(enemies[i], new Vector2(enemies[i].Position.X + 80, enemies[i].Position.Y + 2));
                }
            }
        }

        private void UpdateExpolsions(GameTime gameTime)
        {
            for (int i = explosions.Count - 1; i >= 0; i--)
            {
                explosions[i].Update(gameTime);

                if (explosions[i].IsActive == false)
                {
                    explosions.RemoveAt(i);
                }
            }
        }

        private void PlayMusic(Song gameplayMusic)
        {
            try
            {
                MediaPlayer.Play(gameplayMusic);
                MediaPlayer.IsRepeating = true;
                MediaPlayer.Volume = 0.4f;
            }
            catch (Exception)
            {
            }
        }
    }
}
