using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FactoryPattern
{
    public struct Flavor
    {
        private String name;
        private Color color;

        public String Name
        {
            get
            {
                return name;
            }
        }
        public Color Color
        {
            get
            {
                return color;
            }
        }

        public Flavor(String name, Color color)
        {
            this.name = name;
            this.color = color;
        }
    }
}
