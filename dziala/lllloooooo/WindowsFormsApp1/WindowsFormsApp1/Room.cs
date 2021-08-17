using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Room : Location
    {
        private string description;
        public Room(string name,string description)
            : base(name)
        {
            this.description = description;
        }
        public override string Description
        {
            get
            {
                return base.Description + " Widzisz tutaj " + description + ".";
            }
        }
    }
}
