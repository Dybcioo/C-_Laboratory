using System;
using System.Collections.Generic;
using System.Text;

namespace lab04
{
    class Being
    {
        public string Name { get; set; }
        public double Height { get; set; }

        public Being(string name, double height)
        {
            Name = name;
            Height = height;
        }

        public Being() { }
    }
}
