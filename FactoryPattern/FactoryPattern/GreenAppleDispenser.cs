using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class GreenAppleDispenser : Dispenser
    {
        public GreenAppleDispenser():base(new Flavor("Green Apple", System.Drawing.Color.LimeGreen))
        {

        }
    }
}
