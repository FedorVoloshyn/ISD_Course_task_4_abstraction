using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_4_abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int chosen_exersise = -1;

            while (chosen_exersise != 0)
            {
                Console.WriteLine("\tISD Course. Task 4. Homework by Fedor Voloshyn.\n");
                Console.WriteLine("Enter number of exercise or '0' to exit: ");
                chosen_exersise = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (chosen_exersise)
                {
                    case 0: Console.WriteLine("Have a nice day!");
                        break;
                    case 1: ExerciseOne();
                        break;
                    case 2: ExerciseTwo();
                        break;
                    default: Console.WriteLine("Looks like you entered wrong number! Try again ;)");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void ExerciseOne()
        {
            AbstractHandler docEditor;
            bool correctFlag = false;
            int choose = -1;

            Console.WriteLine("Enter type of document.");
            Console.WriteLine("1. XML");
            Console.WriteLine("2. TXT");
            Console.WriteLine("3. DOC");

            while (!correctFlag)
            {
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1: docEditor = new XMLHandler();
                        correctFlag = true;
                        break;
                    case 2: docEditor = new TXTHandler();
                        correctFlag = true;
                        break;
                    case 3: docEditor = new DOCHandler();
                        correctFlag = true;
                        break;
                    default: Console.WriteLine("Unknown type of document! Try again: ");
                        break;
                }
            }

            while (choose != 0)
            {
                Console.WriteLine("Enter what you want: ");
                Console.WriteLine("1. Open file.");
                Console.WriteLine("2. Change file.");
                Console.WriteLine("3. Create file.");
                Console.WriteLine("4. Save file.");
                choose = int.Parse(Console.ReadLine());
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1: docEditor.Open();
                        break;
                    case 2: docEditor.Change();
                        break;
                    case 3: docEditor.Create();
                        break;
                    case 4: docEditor.Save();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void ExerciseTwo()
        {
        }
    }
}
