using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModernAppliances.Entities.Abstract;

namespace ModernAppliances.Helpers
{
    /// <summary>
    /// Random comparer to randomly sort list.
    /// </summary>
    internal class RandomComparer : IComparer<Appliance>
    {
        private readonly Random _random = new Random();

        /// <summary>
        /// Determines if x is less than, equal to, or greater than y
        /// </summary>
        /// <param name="x">First item</param>
        /// <param name="y">Second item</param>
        /// <returns>Number indicating if x should be before, after, or at the same position as y</returns>
        public int Compare(Appliance x, Appliance y)
        {
            if (x == y)
            {
                return 0;
            }

            return _random.Next(-1, 1);
        }
    }
}
