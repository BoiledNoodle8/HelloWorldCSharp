﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldExample
{
    public class Car
    {
        public string make;
        public string model;
        int year;
        string VIN;
        string exteriorColor;
        string interiorColor;
        public Car(string make, string model, int year, string vIN, string exteriorColor, string interiorColor)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.VIN = vIN;
            this.exteriorColor = exteriorColor;
            this.interiorColor = interiorColor;
        }
    }
}
