using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * 
 * Задача 4. Класс «Мой двумерный массив» 
 * Разработать класс для работы с двумерным массивом. 
 * Сделать методы поиска среднего значения, максимального элемента 
 * массива, минимального элемента массива, 
 * подсчета количества положительных элементов массива,
 * вывода массива на экран и метод, возвращающий массив в виде строки.
 * 
 * */

namespace _04les06
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayTwoDim a = new MyArrayTwoDim(10, 0, 100);
            Console.WriteLine(a.ToString());
            Console.WriteLine($"Минимальный элемент: {a.Min}");
            Console.WriteLine($"Максимальный элемент: {a.Max}");
            Console.WriteLine($"Среднее значение элементов: {a.Average}");

            Console.ReadKey();
        }
    }
}
