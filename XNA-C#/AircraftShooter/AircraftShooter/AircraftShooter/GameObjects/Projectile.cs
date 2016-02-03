namespace AircraftShooter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class Projectile : GameObject
    {
        public bool IsActive;
        public int Damage;
        private Viewport viewport;

        public void Initialize(Viewport viewport, Texture2D texture, Vector2 position)
        {
            this.viewport = viewport;
            this.Texture = texture;
            this.Position = position;
            this.BoundingRectangle = new Rectangle((int)Position.X, (int)Position.Y, Width, Height);
            this.IsActive = true;
            this.Damage = 10;
            this.Velocity.Y = 15.0f;
        }

        public void UpdateUp()
        {
            Position.Y -= Velocity.Y;
            if (Position.Y + Height / 2 < 0)
            {
                IsActive = false;
            }
        }

        public void UpdateDown()
        {
            Position.Y += Velocity.Y;
            if (Position.Y + Height / 2 > viewport.Height)
            {
                IsActive = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch, SpriteEffects effect)
        {
            spriteBatch.Draw(Texture, Position, null, Color.White, 0f, Vector2.Zero, 1.5f, effect, 0f);
        }
    }
}
