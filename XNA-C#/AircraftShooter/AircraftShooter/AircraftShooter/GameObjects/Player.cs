namespace AircraftShooter
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Player : GameObject
    {
        public bool IsAlive;

        public int Health;

        public void Initialize(Texture2D texture, Vector2 position)
        {  
            this.Texture = texture;
            this.Position = position;
            this.BoundingRectangle = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
            this.IsAlive = true;
            this.Health = 100;
            this.Velocity.X = 10f;
            this.Velocity.Y = 10f;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Texture, this.Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
    }
}
