﻿using santafactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace santafactory.Entities
{
    public class CarFactory : IToyFactory
    {
        public Abstractions.Toy CreateNew()
        {

           return new Toy();
        }
    }
}
