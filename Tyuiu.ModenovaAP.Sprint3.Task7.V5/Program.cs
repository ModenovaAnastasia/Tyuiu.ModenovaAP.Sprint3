using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ModenovaAP.Sprint3.Task7.V5.Lib;

namespace Tyuiu.ModenovaAP.Sprint3.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5, stopValue = 5;
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Моденова А. П. | ИИПб-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #3                                                                *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                    *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #5                                                               *");
            Console.WriteLine("* Выполнила: Моденова Анастасия Павловна | ИИПб-23-3                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции             *");
            Console.WriteLine("* f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку        *");
            Console.WriteLine("* деления на 0. При делении на 0 вернуть значение 0.                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0, 5:d}     |  {1, 6:f2}  |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
