using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    class ComparatorClass : IComparer<KeyValuePair<String, int>>
    {
        public int Compare(KeyValuePair<string, int> x, KeyValuePair<string, int> y)
        {
            int o1 = x.Value;
            int o2 = y.Value;
            return o1.CompareTo(o2);
        }
    }
}
