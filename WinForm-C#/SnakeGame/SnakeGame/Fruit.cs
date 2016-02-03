namespace SnakeGame
{
    using System.Drawing;

    public class Fruit
    {
        public Fruit(int x, int y, int width, int height, int point, Brush fruitColor)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Point = point;
            this.FruitColor = fruitColor;
            this.FruitBody = new Rectangle(x, y, width, height);
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Point { get; set; }

        public Brush FruitColor { get; set; }

        public Rectangle FruitBody { get; set; } 
    }
}
