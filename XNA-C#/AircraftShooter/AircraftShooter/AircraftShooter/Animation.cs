namespace AircraftShooter
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Animation
    {
        private Texture2D sprite;
        private float scale;
        private int elapsedTime;
        private int frameTime;
        private int frameCount;
        private int currentFrame;
        private Rectangle destRect;
        private Rectangle sourceRect;

        public int FrameWidth
        {
            get {return sprite.Width / frameCount;}
        }

        public int FrameHeight
        {
            get {return sprite.Height;}
        }

        public bool IsActive;
        public bool IsLooping;
        public Vector2 Position;

        public void Initialize(Texture2D texture, Vector2 position, int frameCount, int frameTime, float scale, bool looping)
        {
            this.sprite = texture;
            this.Position = position;
            this.frameCount = frameCount;
            this.frameTime = frameTime;
            this.scale = scale;
            this.IsLooping = looping;

            this.elapsedTime = 0;
            this.currentFrame = 0;
            this.IsActive = true;
        }

        public void Update(GameTime gameTime)
        {
            if (IsActive == false)
            {
                return;
            }
            elapsedTime += (int)gameTime.ElapsedGameTime.TotalMilliseconds;
            if (elapsedTime > frameTime)
            {
                currentFrame++;
                if (currentFrame == frameCount)
                {
                    currentFrame = 0;
                    if (IsLooping == false)
                    {
                        IsActive = false;
                    }
                }
                elapsedTime = 0;
            }

            sourceRect = new Rectangle(currentFrame * FrameWidth, 0, FrameWidth, FrameHeight);
            destRect = new Rectangle((int)Position.X - (int)(FrameWidth * scale) / 2, (int)Position.Y - (int)(FrameHeight * scale) / 2, 
                (int)(FrameWidth * scale), (int)(FrameHeight * scale));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (IsActive)
            {
                spriteBatch.Draw(sprite, destRect, sourceRect, Color.White);
            }
        }
    }
}
