using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Pitcher
    {
        public Pitcher(Ball ball)
        {
            ball.BallInPlay += Ball_BallInPlay;
        }

        private void Ball_BallInPlay(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        void ball_BallInPlay(object sender, EventArgs e)
        {
            if(e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance < 29) && (ballEventArgs.Trajectory < 60))
                    CatchBall();
                else
                    CoverFirstBase();
            }
        }
    }
}
