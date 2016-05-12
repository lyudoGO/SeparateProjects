namespace Labyrinth2D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Media;

    public static class Sound
    {
        static SoundPlayer soundFail = new SoundPlayer(Properties.Resources.ringout);
        static SoundPlayer soundWin = new SoundPlayer(Properties.Resources.chimes);
        static SoundPlayer soundKey = new SoundPlayer(Properties.Resources.ding);
        static SoundPlayer soundStart = new SoundPlayer(Properties.Resources.notify);
        static bool soundEnabled = true;
                
        public static void SoundOn()
        {
            soundEnabled = true;
        }

        public static void SoundOff()
        {
            soundEnabled = false;
        }

        public static void PlaySoundFail()
        {
            if (soundEnabled)
            {
                soundFail.Play();              
            }
        }
        public static void PlaySoundWin()
        {
            if (soundEnabled)
            {
                soundWin.Play();
            }  
        }

        public static void PlaySoundKey()
        {
            if (soundEnabled)
            {
                soundKey.Play();
            }
        }

        public static void PlaySoundStart()
        {
            if (soundEnabled)
            {
                soundStart.Play();              
            }
        }
    }
}
