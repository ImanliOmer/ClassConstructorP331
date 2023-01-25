using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorP331
{
    internal class Animal
    {
        public string Name;
        public string Breed;
        public string Color;
        public int Age;

        public string GetDetails()
        {
            return $"{Name} {Breed} {Color} {Age}";
        }
    }
}
