﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class SuperSoldierSerum
    {
        public static string BreakWalls(this OrdinaryHuman h, double wallDensity)
        {
            return ("Przedzieram się przez ścianę o gęstości" + wallDensity + ".");
        }
    }
}
