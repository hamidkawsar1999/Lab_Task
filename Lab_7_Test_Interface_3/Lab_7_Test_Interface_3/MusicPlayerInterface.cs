using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7_Test_Interface_3
{
    interface MusicPlayerInterface
    {
        void Switch(bool on);
        void play(bool on);
        void setVolume(int loudness);
        void playNext();
        void playPrevious();
    }
}
