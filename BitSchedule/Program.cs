using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitSchedule
{
    class Program
    {
        enum DeyOfWeek : byte
        {
            Monday = 0x80,
            Tuesday = 0x40,
            Wednesday = 0x20,
            Thursday = 0x10,
            Friday = 0x08,
            Saturday = 0x04,
            Sunday = 0x02
        }

        static void Main(string[] args)
        {
            Console.WriteLine(@"Расписание:
Для корректироовки воспользуйтесь цифровым блоком :)
1- понедельник
2- вторник
3- среда
4- четверг
5- пятница
6- суббота
7- воскресенье
некорректный ввод (символ) или выход за представленный диапазон (1-7) приводит к окончанию редактированию
одиночный выбор - устанавливает напоминание, повторный - снимает");

            byte scheduleInOneByte = 0x0;

            Schedule(scheduleInOneByte);

            Console.ReadKey();
        }


        static byte Schedule(byte scheduleInOneByte) // функция редактирования расписания
        {
            bool check = true;
            while (check)
            {
                SetConsole(0, 11);

                if (int.TryParse(Console.ReadLine(), out int dayWeek))
                {
                    check = SetCurrentDay(ref scheduleInOneByte, dayWeek);

                    SetConsole(15, 0);

                    Console.WriteLine("{0,8}", Convert.ToString(scheduleInOneByte, 2));
                }
                else
                {
                    break;
                }
            }

            return scheduleInOneByte;
        }

        static bool SetCurrentDay(ref byte scheduleInOneByte, int dayWeek)
        {
            bool isOkay = true;

            switch (dayWeek)
            {
                case 1:

                    scheduleInOneByte = (byte)(scheduleInOneByte ^ (byte)DeyOfWeek.Monday);

                    break;

                case 2:

                    scheduleInOneByte = (byte)(scheduleInOneByte ^ (byte)DeyOfWeek.Tuesday);

                    break;

                case 3:

                    scheduleInOneByte = (byte)(scheduleInOneByte ^ (byte)DeyOfWeek.Wednesday);

                    break;

                case 4:

                    scheduleInOneByte = (byte)(scheduleInOneByte ^ (byte)DeyOfWeek.Thursday);

                    break;

                case 5:

                    scheduleInOneByte = (byte)(scheduleInOneByte ^ (byte)DeyOfWeek.Friday);

                    break;

                case 6:

                    scheduleInOneByte = (byte)(scheduleInOneByte ^ (byte)DeyOfWeek.Saturday);

                    break;

                case 7:

                    scheduleInOneByte = (byte)(scheduleInOneByte ^ (byte)DeyOfWeek.Sunday);

                    break;

                default:

                    isOkay = false;

                    break;
            }

            return isOkay;
        }

        static void SetConsole(int x, int y)
        {
            Console.SetCursorPosition(x, y);

            ClearLine(x);

            Console.SetCursorPosition(x, y);
        }

        static void ClearLine(int startIndex)
        {
            for (int i = startIndex; i < Console.WindowWidth; i++)
            {
                Console.Write(' ');
            }
        }
    }
}