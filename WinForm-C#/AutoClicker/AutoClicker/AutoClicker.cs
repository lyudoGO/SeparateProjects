namespace AutoClicker
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public partial class AutoClicker : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        int clicks = 0;

        public AutoClicker()
        {
            InitializeComponent();
        }

        private void trackBar_counter_Scroll(object sender, EventArgs e)
        {
            label_show_count.Text = string.Format("{0} clicks", trackBar_counter.Value.ToString());
        }

        private void trackBar_time_Scroll(object sender, EventArgs e)
        {
            label_show_delay.Text = string.Format("{0} milliseconds", trackBar_time.Value.ToString());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.MakeClick();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            this.StartClicked();
        }

        private void StartClicked()
        {
            clicks = trackBar_counter.Value;
            button_start.Enabled = false;
            timer.Interval = trackBar_time.Value;
            timer.Enabled = true;
        }

        private void MakeClick()
        {
            clicks--;
            DoMouseClick();
            if (clicks == 0)
            {
                this.StopClick();
            }
        }

        private void StopClick()
        {
            timer.Enabled = false;
            button_start.Enabled = true;
        }

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
    }
}
