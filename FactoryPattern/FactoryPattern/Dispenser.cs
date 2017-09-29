using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class Dispenser
    {
        private Flavor flavor;
        public Flavor Flavor => flavor;

        public Dispenser(Flavor flavor)
        {
            this.flavor = flavor;
        }

        public Slushee Dispense(double amount)
        {
            return new Slushee(flavor, amount);
        }
    }
}
