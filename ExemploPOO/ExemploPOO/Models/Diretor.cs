﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {

        public override void Apresentar()
        {
            Console.WriteLine("Diretor!");
        }

    }
}
