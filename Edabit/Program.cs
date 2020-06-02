using System;

namespace Edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[] {1, 3, 5};
            //Console.WriteLine(Mathematic.GetFib(13));
            //Console.WriteLine(Mathematic.GetFibonachi(13));
            //Console.WriteLine(Mathematic.PowerRanger(3, 1, 9));
            int[] testArr = Arrays.RemoveSmallest(new int[] { 2, 2, 1, 2, 1 });
            Console.WriteLine("[{0}]", string.Join(", ", testArr)); 
        }
    }
}
