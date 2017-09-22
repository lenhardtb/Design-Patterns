using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public interface IFillable
    {
        /// <summary>
        /// Fills with a certain amount of water. Returns false if it is now full and should stop being filled.
        /// </summary>
        /// <param name="amount">Amount to add to the IFillable</param>
        /// <returns>Whether this IFillable is now full </returns>
        bool Fill(double amount);

        /// <summary>
        /// Takes a certain amount of water from this IFillable. Returns false if the IFillable is now empty.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>Whether this IFillable is now empty.</returns>
        bool Empty(double amount);

        bool IsFull { get; }
        bool IsEmpty { get; }

    }

    
}
