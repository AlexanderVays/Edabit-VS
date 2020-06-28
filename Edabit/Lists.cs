using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace Edabit
{
    public class Lists
    {
        public static List<string> fruits = new List<string>{ "Apple", "Pear", "Orange", "Pineapple", "Peach", "Banana", "Mango" };


        // Method with sort a list in ascending order by using Linq
        public List<string> GetSorted(List<string> list) 
        {
            list = list.OrderBy(x => x.FirstOrDefault()).ToList(); // sorting list by ascending order == Apple, Banana....
            list = list.OrderByDescending(x => x.FirstOrDefault()).ToList(); // sorting list by descending order Pineaple, Pear....
            return list;
        }
    }
}
