using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }
}
