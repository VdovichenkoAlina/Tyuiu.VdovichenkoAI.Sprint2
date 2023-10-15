using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VdovichenkoAI.Sprint2.Task5.V12.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint2.Task5.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Вдовиченко А.И. | ИИПб-23-1";
            // Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #12                                                              *");
            Console.WriteLine("* Выполнила: Вдовиченко А.И. | ИИПб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет дату предыдущего дня              *");
            Console.WriteLine("* по заданным значениям пользователем (год, месяц, день).                 *");
            Console.WriteLine("* Заданный год является високосным.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Введите год (переменная g):");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите месяц (переменная m):");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите день (переменная n):");
            int n = Convert.ToInt32(Console.ReadLine());
            int res = Convert.ToInt32(ds.FindDateOfPreviousDay(g, m, n));
            Console.WriteLine($" Дата предыдущего дня: {res}");
            Console.ReadKey();
        }
    }
}
