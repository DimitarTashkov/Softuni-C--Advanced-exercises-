﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Tyre
    {
        public Tyre(int age,double tyrePressure)
        {
            Age = age;
            TyrePressure = tyrePressure;
        }

        public int Age { get; set; }
        public double TyrePressure { get; set; }
    }

}
