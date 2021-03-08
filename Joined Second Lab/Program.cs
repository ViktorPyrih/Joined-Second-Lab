using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joined_Second_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            Output output = new Output();
            bool flag = false;
        Label1:
            if (flag)
            {
                Console.WriteLine("If you wanna crear the console area print yes," +
                    " otherwise -- another phrase:");
                if (Console.ReadLine().ToUpper().Equals("YES"))
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("----------------------------------------");
                }
            }
            Console.WriteLine("Choose the task(1..3) or exit option('EXIT'):");
            TaskEnum task = input.setTask();
            TaskManager manager = new TaskManagerImpl();
        Label:
            switch (task)
            {
                case TaskEnum.TASK_1:
                    int[] array;
                    Console.WriteLine("Print method of input for an array (RANDOM/OWN):");
                    InputMethodsEnum method = input.setMethod();
                    if (method.Equals(InputMethodsEnum.OWN)) 
                    {
                        array = input.customInputArray1();
                    } 
                    else 
                    {
                        array = input.randomInputArray1();
                    }
                    Console.WriteLine("Our array:");
                    output.outArray(array);
                Task1:
                    flag = true;
                    Console.WriteLine("Choose the developer's name for TASK_1\n" +
                        "VIKTOR\n" +
                        "MYKYTA\n" +
                        "MAKSYM\n" +
                        " return option('RETURN')\n reinput option('REINPUT')\n or exit option('EXIT'):");
                    NamesEnum name = input.setName();
                    switch (name)
                    {
                        case NamesEnum.VIKTOR:
                            array = manager.doTask1_1(array);
                            break;
                        case NamesEnum.MYKYTA:
                            manager.doTask2_1(array);
                            break;
                        case NamesEnum.MAKSYM:
                            manager.doTask3_1(array);
                            break;
                        case NamesEnum.REINPUT:
                            goto Label;
                        case NamesEnum.EXIT:
                            goto Label2;
                        default:
                            goto Label1;
                    }
                    Console.WriteLine("Resulted array:");
                    output.outArray(array);
                    goto Task1;
                case TaskEnum.TASK_2:
                    int[][] arr;
                    Console.WriteLine("Print method of input for an array (RANDOM/OWN):");
                    method = input.setMethod();
                    if (method.Equals(InputMethodsEnum.OWN)) 
                    {
                        arr = input.customInputArray2();
                    } 
                    else 
                    {
                        arr = input.randomInputArray2();
                    }
                    Console.WriteLine("Our array:");
                    output.outArray(arr);
                Task2:
                    flag = true;
                    Console.WriteLine("Choose the developer's name for TASK_2\n" +
                        "VIKTOR\n" +
                        "MYKYTA\n" +
                        "MAKSYM\n" +
                        " return option('RETURN')\n or exit option('EXIT'):");
                    name = input.setName();
                    switch (name)
                    {
                        case NamesEnum.VIKTOR:
                            manager.doTask1_2(ref arr);
                            break;
                        case NamesEnum.MYKYTA:
                            manager.doTask2_2(arr);
                            break;
                        case NamesEnum.MAKSYM:
                            manager.doTask3_2(arr);
                            break;
                        case NamesEnum.REINPUT:
                            goto Label;
                        case NamesEnum.EXIT:
                            goto Label2;
                        default:
                            goto Label1;
                    }
                    Console.WriteLine("Resulted array:");
                    output.outArray(arr);
                    goto Task2;
                case TaskEnum.TASK_3:
                    flag = true;
                    Console.WriteLine("Choose the developer's name for TASK_3\n" +
                        "VIKTOR\n" +
                        "MYKYTA\n" +
                        "MAKSYM\n" +
                        " return option('RETURN')\n or exit option('EXIT'):");
                    name = input.setName();
                    switch (name)
                    {
                        case NamesEnum.VIKTOR:
                            Console.WriteLine("Print method of input for an array (RANDOM/OWN):");
                            method = input.setMethod();
                            if (method.Equals(InputMethodsEnum.OWN))
                            {
                                arr = input.customInputArray2();
                            }
                            else
                            {
                                arr = input.randomInputArray2();
                            }
                            Console.WriteLine("Our array:");
                            output.outArray(arr);
                            List<int> list = manager.doTask1_3(arr);
                            Console.WriteLine("Resulted array:");
                            if (list.Count == 0)
                            {
                                Console.WriteLine("Empty!");
                            }
                            else 
                            {
                                output.outArray(list.ToArray());
                            }
                            break;
                        case NamesEnum.MYKYTA:
                            manager.doTask2_3();
                            break;
                        case NamesEnum.MAKSYM:
                            manager.doTask3_3();
                            break;
                        case NamesEnum.EXIT:
                            goto Label2;
                        default:
                            goto Label1;
                    }
                    goto Label;
                default:
                    goto Label2;
            }
        Label2:
            MessageBox.Show("Process has finished!");
            Console.ReadKey();
        }
    }
}
