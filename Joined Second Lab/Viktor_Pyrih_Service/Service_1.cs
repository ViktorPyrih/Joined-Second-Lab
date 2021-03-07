using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joined_Second_Lab.Viktor_Pyrih_Service
{
    public class Service_1
    {
        public void findMaxAndItsQuantity(int[] array, out int max, out int quantity) 
        {
            int maximum = array.Max();
            quantity = array.Where(e => e == maximum).Count();
            max = maximum;
        }

        public void changeArray(int[][] array, int index) 
        {
            for (int i = array.Length - 2; i >= index + 1; i--) 
            {
                array[i + 1] = array[i];
            }
            array[index + 1] = new int[array[0].Length];
        }

        public int[] prepareMatrix(int[][] array) 
        {
            return array.Select(a => {
                int[] tmp = a.Where(e => e % 2 != 0).ToArray();
                Array.Sort(tmp);

                return tmp;
            }).Aggregate((a, b) => a.Concat(b).ToArray());
        }
    }
}
