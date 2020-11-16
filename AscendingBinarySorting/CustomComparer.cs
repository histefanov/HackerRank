using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AscendingBinarySorting
{
    public class CustomComparer : IComparer<string>
    {
        public int Compare(string value1, string value2)
        {
            int onesInValue1 = value1.ToCharArray().Count(c => c == '1');
            int onesInValue2 = value2.ToCharArray().Count(c => c == '1');

            return onesInValue1.CompareTo(onesInValue2);
        }
    }
}
