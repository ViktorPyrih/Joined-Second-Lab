﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}