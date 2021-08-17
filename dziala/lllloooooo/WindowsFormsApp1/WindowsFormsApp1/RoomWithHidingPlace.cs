using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string description, string hidingPlaceName)
            : base(name, description)
        {
            HidingPlaceName = hidingPlaceName;
        }
            public string HidingPlaceName { get; private set; }
        public override string Description
        {
            get
            {
                return base.Description + " Ktoś może ukrywać się " + HidingPlaceName + ".";
            }
        } 
 
    }
}


