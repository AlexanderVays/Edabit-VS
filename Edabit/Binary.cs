using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class Binary
    {
		//converts number to binary and counts ones
		public static int CountOnes(int i)
		{
			string binary = Convert.ToString(i, 2);   //2 = baae (binary)
			int result = binary.Count("1".Contains);
			return result;
		}

		public static int reversedBinaryInteger(int num)
		{
			string binaryNum = Convert.ToString(num, 2);
			Console.WriteLine(binaryNum);
			StringBuilder sb = new StringBuilder();
			for (int i = binaryNum.Length - 1; i >= 0; i--)
			{
				sb.Append(binaryNum[i]);
			}
			Console.WriteLine(sb.ToString());
			int result = Convert.ToInt32(sb.ToString(), 2);
			Console.WriteLine(result);
			return result;
		}
	}
}
