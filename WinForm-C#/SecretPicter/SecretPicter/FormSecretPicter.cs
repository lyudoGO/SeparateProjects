using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretPicter
{
    public partial class FormSecretPicter : Form
    {
        bool isSecret = false;

        public FormSecretPicter()
        {
            InitializeComponent();
        }

        private void buttonPicterOne_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.car1;
        }

        private void buttonPicterTwo_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.car2;
        }

        private void buttonPicterThree_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.car3;
        }

        private void buttonPicterFour_Click(object sender, EventArgs e)
        {
            if (isSecret)
            {
                this.BackgroundImage = Properties.Resources.car5;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.car4;
            }
            isSecret = false;
        }

        private void FormSecretPicter_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                isSecret = true;
            }
        }
    }
}
