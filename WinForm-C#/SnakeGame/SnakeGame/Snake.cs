namespace SnakeGame
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Drawing;

    public class Snake
    {
        public Snake(int startX, int startY, int width, int height, Brush snakeColor)
        {
            this.StartX = startX;
            this.StartY = startY;
            this.Width = width;
            this.Height = height;
            this.SnakeColor = snakeColor;
            this.Body = InitializeBody();
        }

        public int StartX { get; set; }

        public int StartY { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public Brush SnakeColor { get; set; }

        public Rectangle[] Body { get; set; }

        public void Grow()
        {
            List<Rectangle> tempBody = this.Body.ToList();
            tempBody.Add(new Rectangle(this.Body[this.Body.Length - 1].X, this.Body[this.Body.Length - 1].Y, this.Width, this.Height));
            this.Body = tempBody.ToArray();
        }

        public void Move(Direction direction)
        {
            for (int i = this.Body.Length - 1; i > 0; i--)
            {
                this.Body[i] = this.Body[i - 1];
            }

            switch (direction)
            {
                case Direction.Up:
                    this.Body[0].Y -= this.Height;
                    break;
                case Direction.Down:
                    this.Body[0].Y += this.Height;
                    break;
                case Direction.Left:
                    this.Body[0].X -= this.Width;
                    break;
                case Direction.Right:
                    this.Body[0].X += this.Width;
                    break;
            }
        }

        private Rectangle[] InitializeBody()
        {
            var body = new Rectangle[3];
            for (int i = 0; i < 3; i++)
            {
                body[i] = (new Rectangle(this.StartX, this.StartY, this.Width, this.Height));
                this.StartX -= 10;
            }
            return body;
        }
    }
}
