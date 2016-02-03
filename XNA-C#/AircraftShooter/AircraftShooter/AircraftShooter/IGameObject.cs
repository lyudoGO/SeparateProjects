namespace AircraftShooter
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public interface IGameObject
    {
        Texture2D Texture { get; set; }
        int Width { get; }   
        int Height { get; }
        void Initialize();
        void Update();
        void Draw(SpriteBatch spriteBatch);        
    }
}
