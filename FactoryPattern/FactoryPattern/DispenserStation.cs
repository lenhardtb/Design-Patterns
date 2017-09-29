using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class DispenserStation
    {
        List<Dispenser> dispensers;
        int currentIndex;

        public DispenserStation()
        {
            dispensers = new List<Dispenser>();
            currentIndex = 0;
        }

        public void Add(Dispenser d)
        {
            dispensers.Add(d);
        }

        public void Remove(Dispenser d)
        {
            if (dispensers.IndexOf(d) < currentIndex)
                currentIndex--;
            dispensers.Remove(d);
        }

        public Dispenser Current()
        {
            return dispensers[currentIndex];
        }

        public Dispenser Next()
        {
            int i = currentIndex < dispensers.Count - 1 ? currentIndex + 1 : 0;
            return dispensers[i];
        }

        public Dispenser Previous()
        {
            int i = currentIndex > 0 ? currentIndex - 1 : dispensers.Count - 1;
            return dispensers[i];
        }

        public Dispenser MoveNext()
        {
            currentIndex++;
            if (currentIndex > dispensers.Count - 1) currentIndex = 0;
            return Current();
        }

        public Dispenser MovePrevious()
        {
            currentIndex--;
            if (currentIndex < 0) currentIndex = dispensers.Count - 1;
            return Current();
        }
    }
}
