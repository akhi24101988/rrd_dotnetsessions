﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Models
{
    class Infant : Man
    {
        public override void play()
        {
            Console.WriteLine("Infant is playing");
        }
    }
}