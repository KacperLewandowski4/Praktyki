using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        public bool Run()
        {
            MyPictureBox.Left += Randomizer.Next(1, 4);
            Location += MyPictureBox.Left;
            if (MyPictureBox.Right >= RaceTrackLength)
                return true;
            else
                return false;
        }
        public void TakeStartingPosition()
        {
            MyPictureBox.Left = StartingPosition;
            Location = 0;
        }
    }
}
