// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int ROWS = 3;
int COLS = 3;
int MIN = 1;
int MAX = 9;

int[][] array = GetTwoDimensionArrayWithRandomValue(ROWS, COLS);

Console.WriteLine("Оригинальный массив: ");
Console.WriteLine(PrintMultiArray(array));

int index = GetIndexStringInArrayWithMinSum(array);
Console.WriteLine($"Строка с индексом {index}");


int[][] GetTwoDimensionArrayWithRandomValue(int rows, int cols)
{
    int[][] twoDimensionalArray = new int[rows][];
    for (int i = 0; i < rows; i++)
    {
        twoDimensionalArray[i] = GetArrayWithRandomValue(cols);
    }
    return twoDimensionalArray;
}

int[] GetArrayWithRandomValue(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(MIN, MAX);
    }
    return array;
}

string PrintArray(int[] array)
{
    string result = "";
    foreach (int item in array)
    {
        result = result + item + "\t";
    }
    return result.Trim();
}

string PrintMultiArray(int[][] array)
{
    string result = "";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + PrintArray(array[i]) + "\n";
    }
    return result;
}

int GetIndexStringInArrayWithMinSum(int[][] array)
{
    int[] sum = GetArrayWithMinSum(array);
    return Array.IndexOf(sum, sum.Min());
}

int[] GetArrayWithMinSum(int[][] array)
{
    int[] sum = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        sum[i] = GetSum(array[i]);
    }
    return sum;
}

int GetSum(int[] array)
{
    int sum = 0;
    foreach (int item in array)
    {
        sum = sum + item;
    }
    return sum;
}



// ответ на автотест

/// Вычисление сумм по строкам (на выходе массив с суммами строк)
// public static int[] SumRows(int[,] array)
// {
//     int[] sum = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum[i] += array[i, j];
//         }
//     }
//     return sum;
// }

// Получение индекса минимального элемента в одномерном массиве
// public static int MinIndex(int[] array)
// {
//     int minI = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[minI] > array[i])
//         {
//             minI = i;
//         }
//     }
//     return minI;
// }

// public static void PrintResult(int[,] numbers)
// {
//     int[] sums = SumRows(numbers);
//     int minIndex = MinIndex(sums);
//     Console.Write(minIndex);
// }




// using System;

// public class Answer
// {
//     public static int SumOfRow(int[,] matrix, int row)
//     {
//         // Введите свое решение ниже
//         int sum = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             sum += matrix[row, i];
//         }
//         return sum;
//     }
//     public static int[] MinimumSumRow(int[,] matrix)
//     {
//         // Введите свое решение ниже
//         int[] minSumRow = { 0, SumOfRow(matrix, 0) };
//         for (int j = 1; j < matrix.GetLength(1); j++)
//         {
//             if (SumOfRow(matrix, j) < minSumRow[1])
//             {
//                 minSumRow[0] = j;
//                 minSumRow[1] = SumOfRow(matrix, j);
//             }
//         }
//         return minSumRow;
//     }
//     // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int[,] matrix;
//         if (args.Length == 0)
//         {
//             // Если аргументы не переданы, используем матрицу по умолчанию
//             matrix = new int[,]
//             {
//                 {9, 1, 7},
//                 {1, 2, 3},
//                 {4, 5, 6}
//             };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в двумерный массив
//             string[] rows = args[0].Split(';');
//             matrix = new int[rows.Length, rows[0].Split(',').Length];
//             for (int i = 0; i < rows.Length; i++)
//             {
//                 string[] elements = rows[i].Split(',');
//                 for (int j = 0; j < elements.Length; j++)
//                 {
//                     if (int.TryParse(elements[j], out int number))
//                     {
//                         matrix[i, j] = number;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//                         return;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("Исходная матрица:");
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]}\t");
//             }
//             Console.WriteLine();
//         }

//         int[] minSumRow = MinimumSumRow(matrix);

//         Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");
//     }
// }