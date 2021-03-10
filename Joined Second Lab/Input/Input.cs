using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joined_Second_Lab
{
    class Input
    {
        public TaskEnum setTask()
        {
            string tmp = Console.ReadLine().Trim();
            TaskEnum operation;
            int val;
            if (int.TryParse(tmp, out val) || !Enum.TryParse(tmp, true, out operation))
            {
                Console.WriteLine("Unsupported operation! Repeat the input, please!");
                return setTask();
            }

            return operation;
        }

        public InputMethodsEnum setMethod()
        {
            string tmp = Console.ReadLine().Trim();
            InputMethodsEnum operation;
            int val;
            if (int.TryParse(tmp, out val) || !Enum.TryParse(tmp, true, out operation))
            {
                Console.WriteLine("Unsupported operation! Repeat the input, please!");
                return setMethod();
            }

            return operation;
        }

        public NamesEnum setName()
        {
            string tmp = Console.ReadLine().Trim();
            NamesEnum name;
            int val;
            if (int.TryParse(tmp, out val) || !Enum.TryParse(tmp, true, out name))
            {
                Console.WriteLine("Unsupported operation! Repeat the input, please!");
                return setName();
            }

            return name;
        }

        public int[] customInputArray1()
        {
            int[] array;
            Console.WriteLine("Print elements one by one separated by ' ' delimiter");
            try
            {
                array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            catch (FormatException)
            {
                Console.WriteLine("Illegal format. Repeat the input, please:");

                return customInputArray1();
            }

            return array;
        }

        public int[] randomInputArray1()
        {
            Console.WriteLine("Print quantity of elements in your array:");
            int n = inputInt();
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-100, 100);
            }

            return array;
        }

        public int[][] customInputArray2()
        {
            Console.WriteLine("Print width and length of your array:");
            int[] parameters = inPair();
            int n = parameters[0];
            int m = parameters[1];
            int[][] array = new int[n][];
            Console.WriteLine("Print elements of an array as separated lines:");
            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + ")");
                while (true)
                {
                    array[i] = customInputArray1();
                    if (array[i].Length == m)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong quantity of elements! Repeat the input please:");
                    }
                }
            }

            return array;
        }

        public int[][] randomInputArray2()
        {
            Console.WriteLine("Print width and length of your array:");
            int[] parameters = inPair();
            int n = parameters[0];
            int m = parameters[1];
            int[][] array = new int[n][];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = new int[m];
                for (int j = 0; j < m; j++) 
                {
                    array[i][j] = random.Next(-100, 100);
                }
            }

            return array;
        }

        public int[,] customInputArray3(int n)
        {
            int[,] array = new int[n, n];
            Console.WriteLine("Print elements of an array as lines:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }

        public int[,] randomInputArray3(int n)
        {
            int[,] array = new int[n,n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i,j] = random.Next(-100, 100);
                }
            }
            return array;
        }

        private int inputInt()
        {
            string s = Console.ReadLine();
            int a;
            if (!int.TryParse(s, out a) || a <= 0)
            {
                Console.WriteLine("Wrong value! Repeat the input, please:");
                return inputInt();
            }

            return a;
        }

        private int[] inPair() 
        {
            int[] array;
            try
            {
                array = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (array.Length > 2 || array.Min() <= 0) 
                {
                    Console.WriteLine("Illegal format. Repeat the input, please:");

                    return customInputArray1();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Illegal format. Repeat the input, please:");

                return customInputArray1();
            }
            

            return array;
        }
    }
}
