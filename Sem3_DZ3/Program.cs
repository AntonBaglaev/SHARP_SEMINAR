// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива. 

// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_003
{
    public class Task_003
    {
       public const int MIN = 1;
        public const int MAX = 99;

        public static void Main(string[] args) {
            System.Console.Write("Введите размерность генерируемого массива: ");

            int arraySize = GetArraySizeFromConsole();
            while (arraySize < 0.0) {
                arraySize = GetArraySizeFromConsole();
            }

            double[] array = GetArrayWithRandomValue(arraySize);

            System.Console.WriteLine("Оригинальный массив:");
            System.Console.WriteLine(PrintArray(array));

            System.Console.WriteLine("Разница между максимальным и минимальным значениями элементов массива:");
            System.Console.WriteLine(getDifferenceMaxMinValue(array).ToString("N2"));
        }

        public static int GetArraySizeFromConsole() {
            try{
                return Convert.ToInt32(Console.ReadLine());
            } catch (Exception)
                {
                System.Console.WriteLine("Введеное значение не ядляется числом. Попробуйте снова.");
            }
            return -1;
        }

        public static double[] GetArrayWithRandomValue(int size) {
            double[] array = new double[size];
            for(int i = 0; i < size; i++) {
                array[i] = (new Random().NextDouble()) + (new Random().Next(MIN, MAX));
            }
            return array;
        }

        public static double getDifferenceMaxMinValue(double[] array) {
            double minVal= 0.0;
            double maxVal= 0.0;
            foreach(double item in array) {
                if(item < minVal) minVal = item;
                if(item > maxVal) maxVal = item;
            }
            return maxVal - minVal;
        }

        public static string PrintArray(double[] array) {
            string result = "";
            foreach(double item in array) {
                result = result + item + " ";
            }
            return result;
        } 
    }
}


// ответ на автотест
// public static double FindMin(double[] numbers)
//     {
//         double min = numbers[0];
//         for (int i = 1; i < numbers.Length; i++)
//         {
//             if (min > numbers[i])
//             {
//                 min = numbers[i];
//             }
//         }
//         return min;
//     }

// public static double FindMax(double[] numbers)
//     {
//         double max = numbers[0];
//         for (int i = 1; i < numbers.Length; i++)
//         {
//             if (max < numbers[i])
//             {
//                 max = numbers[i];
//             }
//         }
//         return max;
//     }

// public static void PrintResult(double[] array)
//     {
//         double result = FindMax(array) - FindMin(array);
//         Console.WriteLine(result);
//     }  