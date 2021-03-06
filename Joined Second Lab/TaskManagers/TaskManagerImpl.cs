using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joined_Second_Lab
{
    class TaskManagerImpl : TaskManager
    {
        private Viktor_Pyrih_Service.Service_1 service = new Viktor_Pyrih_Service.Service_1();
        public int[] doTask1_1(int[] array)
        {
            int max, quantity;
            service.findMaxAndItsQuantity(array, out max, out quantity);
            if (max % 2 == 0) {
                int[] arr = new int[array.Length + quantity];
                for (int i = 0, k = 0; i < array.Length; i++, k++) 
                {
                    if (array[i] == max) 
                    {
                        arr[k++] = max / 2;
                        arr[k] = max / 2;
                    } 
                    else
                    {
                        arr[k] = array[i];
                    }
                }
                return arr;
            }

            return array;
        }

        public void doTask1_2(ref int[][] array)
        {
            int val = array.Select(a => a.Max()).Max();
            int n = Array.FindIndex(array, a => a.Max() == val);
            Array.Resize(ref array, array.Length + 1);
            service.changeArray(array, n);
        }

        public List<int> doTask1_3(int[][] array)
        {
            int[] arr = service.prepareMatrix(array);
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] == i + 1) 
                {
                    list.Add(arr[i]);
                }
            }

            return list;
        }
        private Mykyta_Bulatnikov_Service.Service_1 service3 = new Mykyta_Bulatnikov_Service.Service_1();
        public int[] doTask2_1(int[] array)
        {
            array = service3.DeleteTheFirstEven(array);
            return array;
        }

        public int[][] doTask2_2(int[][] array)
        {
            Console.WriteLine("Please, enter one index of the raw to add it into the array");
            array = service3.AddRawByNumber(array, int.Parse(Console.ReadLine()));
            return array;
        }

        public void doTask2_3()
        {
            throw new NotImplementedException();
        }

        private Max_Savyenkov_Service.Service_1 service2 = new Max_Savyenkov_Service.Service_1();
        public int[] doTask3_1(int[] array)
        {
            int count;
            service2.findCountOfNegativeElements(array, out count);
            int[] arr = new int[array.Length + count];
            for (int i = 0, j = 0; i < array.Length; i++, j++)
            {
                if (array[i] < 0)
                {
                    arr[j] = array[i];
                    j++;
                    arr[j] = Math.Abs(array[i]);
                }
                if (array[i] > 0)
                    arr[j] = array[i];
            }
            return arr;
        }

        public int[][] doTask3_2(int[][] array)
        {
            int index;
            service2.findMaxElem(array, out index);
            int[][] arr = new int[array.Length + 1][];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = new int[array[0].Length];
            for (int i = 0, k = 0; i < arr.Length; i++, k++)
            {
                if (i == index)
                {
                    int[] zeros = new int[array[0].Length];
                    for (int l = 0; l < zeros.Length; l++)
                    {
                        zeros[i] = 0;
                    }
                    zeros.CopyTo(arr[i], 0);
                    i++;
                }
                if(i != index)
                {
                    array[k].CopyTo(arr[i], 0);
                }
            }
            return arr;
        }

        public void doTask3_3(ref int[,] A, ref int[,] B)
        {
            List<int> R = new List<int>();
            int lngth = A.GetLength(0);

            for (int i = 0; i < lngth; i++)
            {
                for (int j = 0; j < lngth; j++)
                {
                    if (A[i,j] == B[i,j])
                    {
                        R.Add(A[i, j]);
                    }
                }
            }

            Console.WriteLine("Input num:");
            int s = int.Parse(Console.ReadLine());

            int first = R.IndexOf(s);
            int last = R.LastIndexOf(s);

            int count = 0;
            for (int i = 0; i < R.Count; i++)
            {
                if (R[i] == s)
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                A[first % lngth, last % lngth] = s;
            }
            else if (count == 1)
            {
                B[last % lngth, first % lngth] = s;
            }
            else
            {
                Console.WriteLine("There is no number {0} in matrix`s joint elem.", s);
            }
        }
    }
}
