﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck.FlyBehavior
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}
