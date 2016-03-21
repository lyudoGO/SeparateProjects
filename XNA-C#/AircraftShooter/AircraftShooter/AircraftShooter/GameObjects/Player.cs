namespace AircraftShooter
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using System.Collections.Generic;

    public class Player : GameObject
    {
        private Viewport viewport;
        private int score;
        public bool IsAlive;
        public int Health;
        public List<Projectile> Projectiles;

        public int Score 
        {
            get { return this.score; }
            set { this.score = value; } 
        }

        public void Initialize(Texture2D texture, Vector2 position, Viewport viewport)
        {
            this.viewport = viewport;
            this.Texture = texture;
            this.Position = position;
            this.BoundingRectangle = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
            this.IsAlive = true;
            this.Health = 100;
            this.Score = 0;
            this.Velocity.X = 10f;
            this.Velocity.Y = 10f;
            this.Projectiles = new List<Projectile>();
        }

        public void Update(GameTime gameTime, InputManager inputManager)
        {
            if (inputManager.KeyPressed(new[] { Keys.Left, Keys.A }))
            {
                this.Position.X -= this.Velocity.X;
            }
            if (inputManager.KeyPressed(new[] { Keys.Right, Keys.D }))
            {
                this.Position.X += this.Velocity.X;
            }
            if (inputManager.KeyPressed(new[] { Keys.Up, Keys.W }))
            {
                this.Position.Y -= this.Velocity.Y;
            }
            if (inputManager.KeyPressed(new[] { Keys.Down, Keys.S }))
            {
                this.Position.Y += this.Velocity.Y;
            }

            this.Position.X = MathHelper.Clamp(this.Position.X, 0, (this.viewport.Width - this.Width));
            this.Position.Y = MathHelper.Clamp(this.Position.Y, 0, (this.viewport.Height - this.Height));
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Texture, this.Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
    }
}
