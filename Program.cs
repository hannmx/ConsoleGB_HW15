using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGB_HW15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру дня недели (1 - 7): ");
            int numweek = int.Parse(Console.ReadLine());
            switch (numweek)
            {
                case 1:
                    Console.WriteLine("Понедельник - не выходной день");
                    break;

                case 2:
                    Console.WriteLine("Вторник - не выходной день");
                    break;

                case 3:
                    Console.WriteLine("Среда - не выходной день");
                    break;

                case 4:
                    Console.WriteLine("Четверг - не выходной день");
                    break;

                case 5:
                    Console.WriteLine("Пятница - не выходной день");
                    break;

                case 6:
                    Console.WriteLine("Суббота - выходной день!");
                    break;

                case 7:
                    Console.WriteLine("Воскресенье - выходной день!");
                    break;
                default:
                    Console.WriteLine("Вы ввели неправильное зачение!!!");
                    break;
            }
        }
    }
}
