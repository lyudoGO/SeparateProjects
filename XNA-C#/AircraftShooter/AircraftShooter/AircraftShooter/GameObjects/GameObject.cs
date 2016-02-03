namespace AircraftShooter
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class GameObject : IGameObject
    {
        private Texture2D texture;
        public Vector2 Position;
        public Vector2 Velocity;
        public Rectangle BoundingRectangle;

        public Texture2D Texture 
        {
            get { return this.texture; }
            set { this.texture = value; }
        }

        public int Width 
        {
            get { return this.texture.Width; } 
        }

        public int Height
        {
            get { return this.texture.Height; }
        }

        public virtual void Initialize()
        {
        }

        public virtual void Update()
        {
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, this.Position, Color.White);
        }
    }
}