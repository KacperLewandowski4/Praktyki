﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Oponent
    {
        private Random random;
        private Location myLocation;
        public Oponent(Location startingLocation)
        {
            myLocation = startingLocation;
            random = new Random();
        }
        public void Move()
        {
            bool hidden = false;
            while (!hidden)
            {
                if (myLocation is IHasExteriorDoor)
                {
                    IHasExteriorDoor locationWithDoor = myLocation as IHasExteriorDoor;
                    if (random.Next(2) == 1)
                        myLocation = locationWithDoor.DoorLocation;
                }
                int rand = random.Next(myLocation.Exits.Length);
                myLocation = myLocation.Exits[rand];
                if (myLocation is IHidingPlace)
                    hidden = true;
            }
        }
        public bool Check(Location locationToCheck)
        {
            if (locationToCheck != myLocation)
                return false;
            else
                return true;
        }
    }
}

