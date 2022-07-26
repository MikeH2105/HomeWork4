/*
 Пользователь вводит с клавиатуры дату. Приложе-
ние должно отобразить название сезона и дня недели.
Например, если введено 22.12.2021, приложение должно
отобразить Winter Wednesday.
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВведіть дату ");
            DateTime newDate = Convert.ToDateTime(Console.ReadLine());

            if (newDate.Month == 1 || newDate.Month == 2 || newDate.Month == 12)
            {
                Console.WriteLine("Winter");
            }
            else if (newDate.Month == 3 || newDate.Month == 4 || newDate.Month == 5)
            { 
                Console.WriteLine("Spring");
            }
            else if (newDate.Month == 6 || newDate.Month == 7 || newDate.Month == 8)
            { 
                Console.WriteLine("Summer"); 
            }
            else if (newDate.Month == 9 || newDate.Month == 10 || newDate.Month == 11) 
            { 
                Console.WriteLine("Autumm");
            }

            Console.WriteLine(newDate.DayOfWeek);
            Console.WriteLine("Дякуємо!!!");
            Console.ReadKey();

        }
    }
}
