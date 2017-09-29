using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class OrangeDispenser : Dispenser
    {
        public OrangeDispenser() : base(new Flavor("Orange", System.Drawing.Color.Orange))
        {

        }
    }
}
