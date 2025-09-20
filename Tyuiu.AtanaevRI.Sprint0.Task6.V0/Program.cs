using System;
using Tyuiu.AtanaevRI.Sprint0.Task6.V0.Lib;

namespace Tyuiu.AtanaevRI.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNums = new int[] { 1, 2, 3, 4, 5 };

            // Пример циклической структуры: сложение элементов массива
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(arrayNums));

            // Пример циклической структуры: вычитание элементов массива
            Console.WriteLine("Разность элементов массива = " + DataService.SubstractionArray(arrayNums));

            // Пример циклической структуры: произведение элементов массива
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(arrayNums));

            Console.ReadKey();
        }
    }
}