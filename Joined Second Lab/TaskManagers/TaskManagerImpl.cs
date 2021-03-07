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

        public void doTask2_1(int[] array)
        {
            throw new NotImplementedException();
        }

        public void doTask2_2(int[][] array)
        {
            throw new NotImplementedException();
        }

        public void doTask2_3()
        {
            throw new NotImplementedException();
        }

        public void doTask3_1(int[] array)
        {
            throw new NotImplementedException();
        }

        public void doTask3_2(int[][] array)
        {
            throw new NotImplementedException();
        }

        public void doTask3_3()
        {
            throw new NotImplementedException();
        }
    }
}
