using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joined_Second_Lab.TaskManagers
{
    public class Service_1
    {
        public int[] DeleteTheFirstEven(int[] z)
        {
            if (z.Length == 1)
            {
                Console.WriteLine("The array is too short!");
                return z;
            }
            bool flag = true;
            for (int i = 0; i < z.Length; i++)
            {
                if (z[i] % 2 == 0) { break; }
                if (i == z.Length - 1)
                {
                    Console.WriteLine("There is no even numbers in the array!");
                    return z;
                }
            }
            int[] new_arr = new int[z.Length - 1];
            for (int i = 0, j = 0; i < z.Length; i++, j++)
            {
                if (flag && z[i] % 2 == 0)
                {
                    i++;
                    flag = false;
                }
                new_arr[j] = z[i];
            }
            return new_arr;
        }
    }
}
