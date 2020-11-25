using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7_Test_Interface_3
{
    interface RadioPlayerInterface
    {
        void Switch(bool on);
        void retune(double frequency);
        void setVolume(int loudness);
        void changeChannel();

    }
}
