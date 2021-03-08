using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joined_Second_Lab
{
    public interface TaskManager
    {
        int[] doTask1_1(int[] array);
        void doTask1_2(ref int[][] array);
        List<int> doTask1_3(int[][] array);
        void doTask2_1(int[] array);
        void doTask2_2(int[][] array);
        void doTask2_3();
        int[] doTask3_1(int[] array);
        int[][] doTask3_2(int[][] array);
        void doTask3_3();
    }
}
