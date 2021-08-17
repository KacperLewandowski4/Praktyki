using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game, EntryPointNotFoundException location)
        {
            this.game = game;
            this.location = location;
        }
        public bool Nearby(EntryPointNotFoundException locationToCheck, int distance)
        {
            if(Math.Abs(location.X - locationToCheck.X) < distance &&
                (Math.Abs(location.Y - locationToCheck.Y) < distance))
            {
                return true;
            }
            return false;
        }
    }
    public Point Move (Direction direction,Rectangle boundaries)
    {
        Point newLocation = newLocation;
        switch(direction)
        {
            default: break;
            case direction.Right:
                if (newLocation.X + MoveInterval <= boundaries.Right)
                    newLocation.X += MoveInterval;
                break;
            case direction.Left:
                if (newLocation.X - MoveInterval >= boundaries.Left)
                    newLocation.X -= MoveInterval;
                break;
            case Direction.Up:
                if (newLocation.Y - MoveInterval >= boundaries.Top)
                    newLocation.Y -= MoveInterval;
                break;
            case Direction.Down:
                if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                    newLocation.Y += MoveInterval;
                break;
        }
        return newLocation;
    }
}
