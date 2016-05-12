namespace Labyrinth2D
{
    using System.Drawing;
    using System.Windows.Forms;

    public partial class FormLevelThree : Form
    {
        private int boxCount = 4;

        public FormLevelThree()
        {
            InitializeComponent();
        }

        private void FormLevelThree_Shown(object sender, System.EventArgs e)
        {
            this.StartGame();
        }

        private void label1_MouseEnter(object sender, System.EventArgs e)
        {
            this.RestartGame();
        }

        private void label_key_MouseEnter(object sender, System.EventArgs e)
        {
            label_key.Visible = false;
            label_door.Visible = false;
            Sound.PlaySoundKey();
        }

        private void label_box_one_MouseEnter(object sender, System.EventArgs e)
        {
            Sound.PlaySoundKey();
            ((Label)sender).Visible = false;
            boxCount--;
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            label_flash_one.Visible = !label_flash_one.Visible;
        }

        private void label_finish_MouseEnter(object sender, System.EventArgs e)
        {
            if (boxCount == 0)
            {
                this.FinishGame();
            }
        }

        private void StartGame()
        {
            Point startPoint = label_start.Location;
            startPoint.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(startPoint);
            label_key.Visible = true;
            label_door.Visible = true;
            label_box_one.Visible = true;
            label_box_two.Visible = true;
            label_box_three.Visible = true;
            label_box_four.Visible = true;
            Sound.PlaySoundStart();
        }

        private void FinishGame()
        {
            this.DialogResult = DialogResult.OK;
            Sound.PlaySoundWin();
        }

        private void RestartGame()
        {
            DialogResult dr = MessageBox.Show("Don't cross labyrinth borders!\nPlay again?", "You lose!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.StartGame();
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
        }
    }
}
