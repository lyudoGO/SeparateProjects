namespace Labyrinth2D
{
    using System.Drawing;
    using System.Windows.Forms;

    public partial class FormLevelTwo : Form
    {
        public FormLevelTwo()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            Point startPoint = label_start.Location;
            startPoint.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(startPoint);
            label_key.Visible = true;
            label_door.Visible = true;
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

        private void FormLevelTwo_Shown(object sender, System.EventArgs e)
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

        private void label_finish_MouseEnter(object sender, System.EventArgs e)
        {
            this.FinishGame();
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            label_flash_one.Visible = !label_flash_one.Visible;
            label_flash_two.Visible = !label_flash_two.Visible;
        }
    }
}
