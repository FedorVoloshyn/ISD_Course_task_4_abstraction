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

            do
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
                        docEditor = new DOCHandler();
                        break;
                }
            } while (!correctFlag);

            do
            {
                Console.WriteLine("Enter what you want: ");
                Console.WriteLine("1. Open file.");
                Console.WriteLine("2. Change file.");
                Console.WriteLine("3. Create file.");
                Console.WriteLine("4. Save file.");
                Console.WriteLine("0. Exit.");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1: docEditor.Open();
                        break;
                    case 2: docEditor.Change();
                        break;
                    case 3: docEditor.Create();
                        break;
                    case 4: docEditor.Save();
                        break;
                    case 0: Console.WriteLine("GoodBye!");
                        break;
                    default: Console.WriteLine("Error!");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            } while (choose != 0);
        }
        public static void ExerciseTwo()
        {
            Player iPod = new Player();
            IPlayable playerFunction = (IPlayable)iPod;
            IRecodable recorderFunction = (IRecodable)iPod;

            Console.WriteLine("Choose mode:");
            Console.WriteLine("1. Player.");
            Console.WriteLine("2. Recorder.");

            int choose = int.Parse(Console.ReadLine());

            switch(choose)
            {
                case 1: PlayerFunc(playerFunction);
                    break;
                case 2: RecorderFunc(recorderFunction);
                    break;
                default: Console.WriteLine("Error!");
                    break;
            }
        }

        private static void RecorderFunc(IRecodable recorderFunction)
        {
            int choose;
            Console.WriteLine("Enter what you want: ");
            Console.WriteLine("1. Record.");
            Console.WriteLine("2. Pause.");
            Console.WriteLine("3. Stop.");
            Console.WriteLine("0. Exit.");
            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1: recorderFunction.Record();
                    break;
                case 2: recorderFunction.Pause();
                    break;
                case 3: recorderFunction.Stop();
                    break;
                case 0: Console.WriteLine("GoodBye!");
                    break;
                default: Console.WriteLine("Error!");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        public static void PlayerFunc(IPlayable playerFunction)
        {
            int choose;
            Console.WriteLine("Enter what you want: ");
            Console.WriteLine("1. Play.");
            Console.WriteLine("2. Pause.");
            Console.WriteLine("3. Stop.");
            Console.WriteLine("0. Exit.");
            choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1: playerFunction.Play();
                    break;
                case 2: playerFunction.Pause();
                    break;
                case 3: playerFunction.Stop();
                    break;
                case 0: Console.WriteLine("GoodBye!");
                    break;
                default: Console.WriteLine("Error!");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
