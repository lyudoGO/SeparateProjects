namespace AircraftShooter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Enemy : GameObject
    {
        public bool IsAlive;
        public int Health;
        public int Damage;
        public int Value;
        public List<Projectile> Projectiles;
        public Viewport viewport;

        public void Initialize(Viewport viewport, Texture2D texture, Vector2 position)
        {
            this.viewport = viewport;
            this.Projectiles = new List<Projectile>();
            this.Texture = texture;
            this.Position = position;
            this.BoundingRectangle = new Rectangle((int)Position.X, (int)Position.Y, Width, Height);
            this.IsAlive = true;
            this.Health = 50;
            this.Damage = 10;
            this.Value = 10;
            this.Velocity.Y = 3.0f;
        }

        //private List<Projectile> AddBullets()
        //{
        //    var bullets = new List<Projectile>();
        //    Projectile bullet;
        //    for (int i = 0; i < 8; i++)
        //    {
        //        bullet = new Projectile();
        //        bullet.Velocity.Y = 10f;
        //        bullets.Add(bullet);
        //    }
        //    return bullets;
        //}

        public override void Update()
        {
            Position.Y += Velocity.Y;
            BoundingRectangle.Y = (int)(Position.Y - Width) / 2;

            if (Position.Y > this.viewport.Height || Health <= 0)
            {
                IsAlive = false;
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, null, Color.White, 0f, Vector2.Zero, 1.0f, SpriteEffects.FlipVertically, 0f);
        }
    }
}
