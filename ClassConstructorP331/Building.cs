﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorP331
{
    internal class Building
    {
        public string name;
        public int height;
        public int area;
        public string adress;

        public Building(string name, int height, int area)
        {
            this.name = name;
            this.height = height;
            this.area = area;
        }

        public string GetInfo()
        {
            return $"Name: {name} \nHeight: {height} \nArea: {area}";
        }
        
        public string GetHeight()
        {

            return $"sum:{height * area}";
        }
    }
}
