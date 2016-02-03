namespace AircraftShooter
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    public class ParallaxingBackground
    {
        Texture2D texture;
        Vector2[] positions;
        int speed;

        public void Initialize(ContentManager content, string path, int screenHeight, int speed)
        {
            this.texture = content.Load<Texture2D>(path);
            this.speed = speed;
            this.positions = new Vector2[screenHeight / texture.Height + 3];
            for (int i = 0; i < this.positions.Length; i++)
            {
                this.positions[i] = new Vector2(0, i * texture.Height);
            }
        }

        public void Update()
        {
            for (int i = 0; i < this.positions.Length; i++)
            {
                this.positions[i].Y += speed;
                if (speed <= 0)
                {
                    if (positions[i].Y <= -texture.Height)
                    {
                        positions[i].Y = texture.Height * (positions.Length - 1);
                    }
                }
                else
                {
                    if (positions[i].Y >= texture.Height * (positions.Length - 1))
                    {
                        positions[i].Y = -texture.Height;
                    }
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < positions.Length; i++)
            {
                spriteBatch.Draw(texture, positions[i], Color.White);
            }
        }
    }
}
