using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class MangoDispenser : Dispenser
    {
        public MangoDispenser() : base(new Flavor("Mango", System.Drawing.Color.Gold))
        {

        }
    }
}
