using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_mas4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 4. Массивы 4:Меняет знак всех элементов на противоположный.");
            int v = 33;
            Console.WriteLine("                      Порядковый номер по списку группы: 33");
            Console.WriteLine("                                " + ((v % 9) + 1) + " Вариант");

            Console.Write("Введите количество элементов:");
            var len = int.Parse(Console.ReadLine());

            var array = new int[len];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                 array[i] = rand.Next(-99, 99);
                Console.WriteLine(i + " Элемент = " + array[i]);
            }


            Console.WriteLine("Результат: ");

            for (int i = 0; i < array.Length; i++)
               

                Console.Write(array[i] * -1 + ", ");




                Console.ReadKey();
        }
    }
}
