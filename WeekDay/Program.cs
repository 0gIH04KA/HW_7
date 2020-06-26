using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekDay
{
    class Program
    {
        static int InputIntValue(string message)
        {
            bool isWork;
            int result;
            do
            {
                Console.WriteLine("Enter {0}", message);
                isWork = int.TryParse(Console.ReadLine(), out result);

                if (!isWork)
                {
                    Console.WriteLine("Error format!");
                }

            } while (!isWork);

            return result;
        }

        static void ChooseADay(DaysOfWeek day)
        {
            switch (day)
            {
                case DaysOfWeek.NoDay:
                    day = DaysOfWeek.NoDay;
                    Console.WriteLine(day);
                    break;

                case DaysOfWeek.Monday:
                    day = DaysOfWeek.Monday;
                    Console.WriteLine(day);
                    break;

                case DaysOfWeek.Tuesday:
                    day = DaysOfWeek.Tuesday;
                    Console.WriteLine(day);
                    break;

                case DaysOfWeek.Wednesday:
                    day = DaysOfWeek.Wednesday;
                    Console.WriteLine(day);
                    break;

                case DaysOfWeek.Thursday:
                    day = DaysOfWeek.Thursday;
                    Console.WriteLine(day);
                    break;

                case DaysOfWeek.Friday:
                    day = DaysOfWeek.Friday;
                    Console.WriteLine(day);
                    break;

                case DaysOfWeek.Saturday:
                    day = DaysOfWeek.Saturday;
                    Console.WriteLine(day);
                    break;

                case DaysOfWeek.Sunday:
                    day = DaysOfWeek.Sunday;
                    Console.WriteLine(day);
                    break;

                default:
                    Console.WriteLine("Wrong day... :(");
                    break;
            }
        }

        static void Main(string[] args)
        {
            int day = InputIntValue("first num: ");

            ChooseADay(day);
            Console.ReadKey();
        }
    }
}
