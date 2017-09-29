using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Slushee
    {
        private Dictionary<Flavor, double> contents;

        public Slushee()
            : this(new Flavor[] { }, new double[] { })
        {

        }

        public Slushee(Flavor f, double amount)
            : this(new Flavor[] { f }, new double[] { amount })
        { }

        public Slushee(Flavor[] f, double[] amount)
        {
            if (f.Length != amount.Length) throw new ArgumentException("Number of flavors and amounts of them do not match!");

            contents = new Dictionary<Flavor, double>(f.Length);

            for(int i = 0; i < f.Length; i++)
            {
                AddFlavor(f[i], amount[i]);
            }
        }

        public Flavor[] Flavors => contents.Keys.ToArray();

        public void AddFlavor(Flavor f, double amount)
        {
            if (contents.ContainsKey(f))
            {
                contents[f] += amount;
            }
            else
                contents.Add(f, amount);
        }

        public double Amount
        {
            get
            {
                double total = 0;
                foreach (double amount in contents.Values)
                {
                    total += amount;
                }
                return total;
            }
        }

        public System.Drawing.Color Color
        {
            get
            {
                int r = 0;
                int g = 0;
                int b = 0;

                foreach(KeyValuePair<Flavor, double> pair in contents)
                {
                    r += (int)(pair.Key.Color.R * PercentOf(pair.Key) / 100);
                    g += (int)(pair.Key.Color.G * PercentOf(pair.Key) / 100);
                    b += (int)(pair.Key.Color.B * PercentOf(pair.Key) / 100);
                }
                return System.Drawing.Color.FromArgb(r, g, b);
            }
        }

        public double PercentOf(Flavor f)
        {
            if (contents.ContainsKey(f))
            {
                double fraction = contents[f] / Amount;
                return fraction * 100;
            }
            else
                return 0.0;
        }

        public static Slushee operator +(Slushee s1, Slushee s2)
        {
            Flavor[] allFlavors = new Flavor[s1.contents.Count + s2.contents.Count];
            double[] allAmounts = new double[s1.contents.Count + s2.contents.Count];

            int i;
            for (i = 0; i < s1.contents.Count; i++)
            {
                
                allFlavors[i] = s1.contents.Keys.ElementAt(i);
                allAmounts[i] = s1.contents.Values.ElementAt(i);
            }
            int i2;
            for(i2 = 0; i2 < s2.contents.Count; i2++)
            {
                allFlavors[i + i2] = s2.contents.Keys.ElementAt(i2);
                allAmounts[i + i2] = s2.contents.Values.ElementAt(i2);
            }

            return new Slushee(allFlavors, allAmounts);
        }
    }
}
