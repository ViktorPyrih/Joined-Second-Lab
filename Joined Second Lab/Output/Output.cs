using System;

namespace Joined_Second_Lab
{
    public class Output
    {
        public void outArray(int[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }

        public void outArray(int[][] array) 
        {
            foreach (int[] arr in array)
            {
                foreach (int e in arr)
                {
                    Console.Write("{0, -5}", e);
                }
                Console.WriteLine();
            }
        }

        public void outArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write("{0, -5}", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
