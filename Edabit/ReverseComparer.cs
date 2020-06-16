using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    public class ReverseComparer : IComparer
    {
        public int Compare(Object x, Object y)
        {
            return (new CaseInsensitiveComparer()).Compare(y, x);
        }
    }
}
