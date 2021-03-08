using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joined_Second_Lab.Max_Savyenkov_Service
{
    class Service_1
    {
        public void findCountOfNegativeElements(int[] array, out int count)
        {
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }
        }

        public void findMaxElem(int[][] array, out int indxofline)
        {
            int max = array[0][0];
            indxofline = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].GetLength(0); j++)
                {
                    if (array[i][j] >= max)
                    {
                        max = array[i][j];
                        indxofline = i;
                    }
                }
            }
        }


    }
}
