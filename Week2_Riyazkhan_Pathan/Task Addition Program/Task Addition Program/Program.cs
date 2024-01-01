using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Addition_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();
            bool condition = true;

           while (condition == true)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("1. Create Task ");
                Console.WriteLine("2. Read the Task ");
                Console.WriteLine("3. Update the Task ");
                Console.WriteLine("4. Delete the Task ");
                Console.WriteLine("5. Exit ");
                Console.WriteLine("-------------------------------------------------");

                Console.Write("Enter Your Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                     // Create Task
                    case 1:
                        {
                            Console.WriteLine("Enter the task Details: ");
                            string tasksValue = Console.ReadLine();
                            tasks.Add(tasksValue);
                              

                        }
                        break;

                        //Read Task
                    case 2:
                        {
                            Console.WriteLine("All Tasks :- ");
                            for (int i = 0; i < tasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}) {tasks[i]}");
                            }

                        }
                        break;

                        // Update Task
                    case 3:
                        {
                     
                            for (int i= 0; i < tasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}) {tasks[i]}");
                            }
                    
                            if (tasks.Count == 0)
                            {
                                Console.WriteLine("No Task Are Available to Update");
                            }

                            else
                            {
                                Console.WriteLine("Enter the task number to Update");
                                int index = Convert.ToInt32(Console.ReadLine()) - 1;
                                Console.WriteLine("Enter Updated Details");
                                tasks[index] = Console.ReadLine();
                            }

                        }
                        break;
                        // Delete task
                    case 4:
                        {

                            for (int i = 0; i < tasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}) {tasks[i]}");
                            }

                            if (tasks.Count == 0)
                            {
                                Console.WriteLine("No Task Are Available to Delete");
                            }
                            else 
                            {
                                    Console.WriteLine("Enter the Task Number to Delete:- ");
                                    int number = Convert.ToInt32(Console.ReadLine()) - 1;
                                    tasks.RemoveAt(number);

                            }


                        }
                        break;

                        // Exit
                    case 5:
                        {
                            condition = false;

                        }
                        break;
                    default:
                        {

                            Console.WriteLine("Enter Valid Choice... ");
                            break;
                        }

                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadLine();
                Console.Clear();
            }


        }
    }
}
