using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class BaseCar : ICar
    {
        public BaseCar()
        {
            Extra.Add("Basic car conficuration");
            Cost = 10000;
        }

        public float Cost { get; set; }
        public List<string> Extra { get; set; } = new List<string>();
    }
}
