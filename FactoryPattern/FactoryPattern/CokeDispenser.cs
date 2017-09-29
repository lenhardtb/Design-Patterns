using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class CokeDispenser : Dispenser
    {
        public CokeDispenser(): base(new Flavor("Coca-Cola", System.Drawing.Color.DarkRed))
        {

        }
    }
}
