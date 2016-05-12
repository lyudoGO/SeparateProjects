namespace Labyrinth2D
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class FormLevelOne : Form
    {
        private int boxCount = 5;

        public FormLevelOne()
        {
            InitializeComponent();
        }

        private void FormLevelOne_Shown(object sender, EventArgs e)
        {
            this.StartGame();
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            if (boxCount == 0)
            {
                this.FinishGame();
            }    
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            this.RestartGame();
        }

        private void StartGame()
        {
            Point startPoint = label_start.Location;
            startPoint.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(startPoint);
            Sound.PlaySoundStart();
            label_box_one.Visible = true;
            label_box_two.Visible = true;
            label_box_three.Visible = true;
            label_box_four.Visible = true;
            label_box_five.Visible = true;                                    
        }

        private void FinishGame()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void RestartGame()
        {
            DialogResult dr = MessageBox.Show("Don't cross labyrinth borders!\nPlay again?", "You lose!", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                this.StartGame();
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
        }

        private void label_box_four_MouseEnter(object sender, EventArgs e)
        {
            Sound.PlaySoundKey();
            ((Label)sender).Visible = false;      
            boxCount--;
        }
    }
}
