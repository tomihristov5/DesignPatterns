﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Makes
{
    public class Vw : Car
    {
        public override string Make
        {
            get { return "Vw"; }
        }
    }
}
