using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class Sets
    {
        // Removes duplicates from the array by using HashSet
        public static object[] RemoveDups(object[] str)
        {
            var mySet = new HashSet<object>();
            for (int i = 0; i < str.Length; i++)
            {
                mySet.Add(str[i]);
            }
            object[] result = new object[mySet.Count];
            mySet.CopyTo(result);
            return result;
        }
    }
}
