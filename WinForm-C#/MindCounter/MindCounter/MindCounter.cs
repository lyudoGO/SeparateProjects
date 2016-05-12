using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindCounter
{
    public partial class MindCounter : Form
    {
        int count;
        int min = 1;
        int max = 10;
        int count_max = 10;
        string correctAnswer;
        string mode;
        Random rnd = new Random();

        public MindCounter()
        {
            InitializeComponent();
            textBoxMaxCount.Text = max.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            mode = ((Button)sender).Tag.ToString();
            StartGame(mode);
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            mode = ((Button)sender).Tag.ToString();
            StartGame(mode);
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            mode = ((Button)sender).Tag.ToString();
            StartGame(mode);
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            mode = ((Button)sender).Tag.ToString();
            StartGame(mode);
        }

        private void textBoxAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxAnswer.Text == correctAnswer)
                {
                    progressBar.Value = count;
                    if (count == count_max)
                    {
                        GameWin();
                        return;
                    }
                    textBoxAnswer.Text = string.Empty;
                    Think();
                }
                else
                {
                    GameOver();
                }
            }
        }

        private void StartGame(string mode)
        {
 	        buttonAdd.Enabled = false;
            buttonDivision.Enabled = false;
            buttonMultiplication.Enabled = false;
            buttonSubtraction.Enabled = false;
            labelThink.Enabled = true;
            textBoxAnswer.Enabled = true;
            textBoxAnswer.Text = string.Empty;
            textBoxAnswer.Focus();
            progressBar.Visible = true;
            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = count_max;
            count = 0;
            if (!int.TryParse(textBoxMaxCount.Text, out max))
            {
                max = 10;
                textBoxMaxCount.Text = max.ToString();
            }
            Think();
        }

        private void Think()
        {
            int numA, numB;
            numA = rnd.Next(min, max + 1);
            numB = rnd.Next(min, max + 1);
            switch (mode)
            {
                case "add": 
                    labelThink.Text = string.Format("{0} + {1} = ", numA, numB);
                    correctAnswer = (numA + numB).ToString();            
                    break;
                case "substraction":
                    labelThink.Text = string.Format("{0} - {1} = ", numA, numB);
                    if (numA < numB)
                    {
                        int temp = numA;
                        numA = numB;
                        numB = temp;
                    }
                    correctAnswer = (numA - numB).ToString();
                    break;
                case "multiplication":
                    labelThink.Text = string.Format("{0} * {1} = ", numA, numB);
                    correctAnswer = (numA * numB).ToString();
                    break;
                case "division":
                    labelThink.Text = string.Format("{0} / {1} = ", (numA * numB), numB);
                    correctAnswer = (numA).ToString();
                    break;
                default:
                    break;
            }

            count++;
        }

        private void GameWin()
        {
            MessageBox.Show("You Win!!!");
            Done();
        }

        private void GameOver()
        {
            textBoxAnswer.Text = correctAnswer;
            Done();
        }

        private void Done()
        {
            buttonAdd.Enabled = true;
            buttonDivision.Enabled = true;
            buttonMultiplication.Enabled = true;
            buttonSubtraction.Enabled = true;
            progressBar.Visible = false;
            labelThink.Enabled = false;
            textBoxAnswer.Enabled = false;
            buttonAdd.Focus();
        }

    }
}
