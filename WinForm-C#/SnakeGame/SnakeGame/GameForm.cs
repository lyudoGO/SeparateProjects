using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class GameForm : Form
    {
        private Brush[] fruitBrushes = { Brushes.Black, Brushes.Green, Brushes.Orange, Brushes.Red, Brushes.Yellow };
        private int[] fruitsCount;
        private Snake snake;
        private Fruit fruit;
        private Graphics canvas;
        private int score;
        private float speed;
        private int width;
        private int height;
        private Direction direction;
        private bool gameOver;

        public GameForm()
        {
            InitializeComponent();
            InitializeGameSettings();
            labelGameStart.Visible = true;
            gameTimer.Tick += Update;
        }

        private void InitializeGameSettings()
        {
            score = 0;
            speed = 10;
            width = 10;
            height = 10;
            fruitsCount = new int[5];
            direction = Direction.Right;
            gameOver = false;
            ResetScore();
            snake = new Snake(20, 0, width, height, Brushes.BurlyWood);
            GenarateFruit();
        }

        private void StartGame()
        {
            InitializeGameSettings();
            labelGameStart.Visible = false;
            labelGameOver.Visible = false;
            gameTimer.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            snake.Move(direction);
            DetectCollision();
            IncreaseSpeed();

            pictureBoxGame.Invalidate();
        }

        private void pictureBoxGame_Paint(object sender, PaintEventArgs e)
        {
            canvas = e.Graphics;
            // Draw snake
            canvas.FillRectangle(Brushes.Brown, snake.Body[0]);
            for (int i = 1; i < snake.Body.Length; i++)
            {
                canvas.FillRectangle(snake.SnakeColor, snake.Body[i]);
            }

            // Draw fruit
            canvas.FillEllipse(fruit.FruitColor, fruit.FruitBody);
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    if (labelGameStart.Visible || gameOver)
                    {
                        StartGame();
                    }
                    break;
                case Keys.Space:
                    if (!labelGameStart.Visible && !gameOver)
                    {
                        gameTimer.Enabled = (gameTimer.Enabled) ? false : true;
                        if (!gameTimer.Enabled)
                        {
                            labelGameOver.Visible = true;
                            labelGameOver.Text = "PAUSE";
                        }
                        else
                        {
                            labelGameOver.Visible = false;
                        }
                    }
                    break;
                case Keys.Up:
                    if (direction != Direction.Down)
                    {
                        direction = Direction.Up;
                    }
                    break;
                case Keys.Down:
                    if (direction != Direction.Up)
                    {
                        direction = Direction.Down;
                    }
                    break;
                case Keys.Left:
                    if (direction != Direction.Right)
                    {
                        direction = Direction.Left;
                    }
                    break;
                case Keys.Right:
                    if (e.KeyData == Keys.Right && direction != Direction.Left)
                    {
                        direction = Direction.Right;
                    }
                    break;
            }
        }

        private void GenarateFruit()
        {
            int maxXPos = pictureBoxGame.Size.Width - width;
            int maxYPos = pictureBoxGame.Size.Height - height;
            Random rnd = new Random();
            int x = rnd.Next(0, maxXPos);
            int y = rnd.Next(0, maxYPos);
            int point = rnd.Next(1, 5);
            fruit = new Fruit(x, y, width, height, point, fruitBrushes[point]);
        }

        private void GameOver()
        {
            gameTimer.Stop();
            gameOver = true;
            labelGameOver.Visible = true;
            labelGameOver.Text = "GAME OVER";
        }

        private void DetectCollision()
        {
            if (IsHitWithGameBoard())
            {
                GameOver();
            }
            if (IsHitWithSnakeBody())
            {
                GameOver();
            }
            if (IsHitWithFruit())
            {
                EatFruit();
                GenarateFruit();
            }
        }

        private void IncreaseSpeed()
        {
            speed += 0.003f;
            gameTimer.Interval = 1000 / (int)speed;
        }

        private void EatFruit()
        {
            snake.Grow();
            UpdateScoreAndFruitsCount();
        }

        private void ResetScore()
        {
            labelScoreValue.Text = "0";
            labelAppleCount.Text = "0";
            labelOrangeCount.Text = "0";
            labelTomatoCount.Text = "0";
            labelLemonCount.Text = "0";
        }

        private void UpdateScoreAndFruitsCount()
        {
            score += fruit.Point;
            labelScoreValue.Text = score.ToString();

            fruitsCount[fruit.Point]++;
            switch (fruit.Point)
            {
                case 1: labelAppleCount.Text = fruitsCount[fruit.Point].ToString(); break;
                case 2: labelOrangeCount.Text = fruitsCount[fruit.Point].ToString(); break;
                case 3: labelTomatoCount.Text = fruitsCount[fruit.Point].ToString(); break;
                case 4: labelLemonCount.Text = fruitsCount[fruit.Point].ToString(); break;
            }
        }

        private bool IsHitWithSnakeBody()
        {
            for (int i = 1; i < snake.Body.Length; i++)
            {
                if (snake.Body[0].IntersectsWith(snake.Body[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsHitWithGameBoard()
        {
            return snake.Body[0].X < 0 || snake.Body[0].Y < 0 ||
                   snake.Body[0].X >= pictureBoxGame.Size.Width || snake.Body[0].Y >= pictureBoxGame.Size.Height;
        }

        private bool IsHitWithFruit()
        {
            return snake.Body[0].IntersectsWith(fruit.FruitBody);
        }
    }
}