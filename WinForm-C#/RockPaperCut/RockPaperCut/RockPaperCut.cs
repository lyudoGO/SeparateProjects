using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperCut
{
    public partial class RockPaperCut : Form
    {
        string[] types = { "rock", "paper", "cut" };
        string userFigure = string.Empty;
        string cpuFigure = string.Empty;
        Random rg = new Random();
        int scoreWins = 0;
        int scoreLosts = 0;
        int scoreDraw = 0;
        bool isPlay = true;

        public RockPaperCut()
        {
            InitializeComponent();
        }

        private void panelPicterOne_MouseEnter(object sender, EventArgs e)
        {
            ShowUserFigure(((Panel)sender).Tag.ToString());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isPlay)
            {
                ChooseCpuFigure();
            }    
        }

        private void pictureBoxRock_MouseClick(object sender, MouseEventArgs e)
        {
            int result = CheckResult();
            PrintResult(result);
        }

        private void ShowUserFigure(string name)
        {
            StartGame();
            pictureBoxRock.Visible = name == types[0];
            pictureBoxPaper.Visible = name == types[1];
            pictureBoxCut.Visible = name == types[2];
            userFigure = name;
        }

        private void StartGame()
        {
            if (!isPlay)
            {
                isPlay = true;
                labelInfo.Text = "Choose your figure...";
            }
        }

        private void ShowCpuFigure(string name)
        {
            pictureBoxRockCPU.Visible = name == types[0];
            pictureBoxPaperCPU.Visible = name == types[1];
            pictureBoxCutCPU.Visible = name == types[2];
            cpuFigure = name;
        }

        private void ChooseCpuFigure()
        {
            int index = rg.Next(1, 4);
            switch (index)
            {
                case 1: ShowCpuFigure(types[0]); break;
                case 2: ShowCpuFigure(types[1]); break;
                case 3: ShowCpuFigure(types[2]); break;
            }
        }

        private void ShowScore()
        {
            labelScore.Text = string.Format("Wins: {0} Losts: {1} Draw: {2}", scoreWins, scoreLosts, scoreDraw);
        }

        private void PrintResult(int result)
        {
            switch (result)
            {
                case -1: labelInfo.Text = "You lose!"; break;
                case 0: labelInfo.Text = "Draw game!"; break;
                case 1: labelInfo.Text = "You win!"; break;
            }
            ShowScore();
        }

        private int CheckResult()
        {
            isPlay = false;
            int result = 0;
            if (userFigure == cpuFigure)
            {
                scoreDraw++;
            }
            else
            {
                switch (userFigure)
                {
                    case "rock":
                        if (cpuFigure == types[1])
                        {
                            scoreLosts++;
                            result = -1;
                        }
                        else
                        {
                            scoreWins++;
                            result = 1;
                        }
                        break;
                    case "paper":
                        if (cpuFigure == types[2])
                        {
                            scoreLosts++;
                            result = -1;
                        }
                        else
                        {
                            scoreWins++;
                            result = 1;
                        }
                        break;
                    case "cut":
                        if (cpuFigure == types[0])
                        {
                            scoreLosts++;
                            result = -1;
                        }
                        else
                        {
                            scoreWins++;
                            result = 1;
                        }
                        break;
                    default: break;
                }
            }
            return result;
        }

        private void trackBarSpeed_ValueChanged(object sender, EventArgs e)
        {
            SetCpuSpeed();
        }

        private void SetCpuSpeed()
        {
            int speed = trackBarSpeed.Value;
            switch (speed)
            {
                case 1: timer.Interval = 400; break;
                case 2: timer.Interval = 300; break;
                case 3: timer.Interval = 200; break;
                case 4: timer.Interval = 100; break;
                case 5: timer.Interval = 50; break;
            }
           
        }

    }
}
