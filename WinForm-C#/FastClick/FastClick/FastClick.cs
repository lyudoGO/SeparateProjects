namespace FastClick
{
    using System;
    using System.Windows.Forms;

    public partial class FastClick : Form
    {
        long startTime;
        long endTime;
        int maxCounter = 10;
        int counter = 0;
        string mode = "stop";

        public FastClick()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            this.StartGame();
        }

        private void label_counter_MouseDown(object sender, MouseEventArgs e)
        {
            this.PlayGame();
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author Lyudo:)\n© 2016", "Info");
        }

        private void StartGame()
        {
            if (mode == "play")
            {
                return;
            }
            mode = "play";
            counter = maxCounter;
            label_counter.Text = counter.ToString();
            label_message.Text = "";
            button_start.Enabled = false;
        }

        private void PlayGame()
        {
            if (mode == "stop")
            {
                return;
            }

            if (counter == 10)
            {
                startTime = DateTime.Now.Ticks;
            }

            if (counter > 0)
            {
                counter--;
            }
            label_counter.Text = counter.ToString();

            if (counter == 0)
            {
                this.StopGame();
            }
        }

        private void StopGame()
        {
            mode = "stop";
            endTime = DateTime.Now.Ticks;
            double seconds = TimeSpan.FromTicks(endTime - startTime).TotalSeconds;
            double clicksPerSecond = maxCounter / seconds;
            label_message.Text = string.Format("{0:#.#} clicks for second", clicksPerSecond);
            button_start.Enabled = true;
        }
    }
}
