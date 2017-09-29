using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class BlueRazzDispenser : Dispenser
    {
        public BlueRazzDispenser(): base(new Flavor("Blue Razzberry", System.Drawing.Color.Blue))
        {

        }
    }
}
