using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string description, string doorDescription, string hidingPlaceName)
            : base(name, description, hidingPlaceName)
        {
            DoorDescription = doorDescription;
        }
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
    }
}
