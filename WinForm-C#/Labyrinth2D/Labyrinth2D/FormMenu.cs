using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrinth2D
{
    public partial class Labyrinth2D : Form
    {
        public Labyrinth2D()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxSound_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSound.Checked)
            {
                checkBoxSound.Text = "Sound On";
                Sound.SoundOn();
            }
            else
            {
                checkBoxSound.Text = "Sound Off";
                Sound.SoundOff();
            }
            Sound.PlaySoundKey();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            //StartLevleOne();
            StartLevelThree();
        }

        private void StartLevleOne()
        {
            Sound.PlaySoundStart();
            FormLevelOne levelOne = new FormLevelOne();
            DialogResult dr = levelOne.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.StartLevelTwo();
            }
        }

        private void StartLevelTwo()
        {
            Sound.PlaySoundStart();
            FormLevelTwo levelTwo = new FormLevelTwo();
            DialogResult dr = levelTwo.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.StartLevelThree();
            }
        }

        private void StartLevelThree()
        {
            Sound.PlaySoundStart();
            FormLevelThree levelThree = new FormLevelThree();
            DialogResult dr = levelThree.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Sound.PlaySoundWin();
                MessageBox.Show("Game completed.", "You win!");
            }
        }
    }
}
