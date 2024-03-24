// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 5;
int m = 7;
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(10, 99);
        Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();
}
if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует  ");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
}
Console.ReadLine();

// ответ на автотест

// Поиск элемента по позициям
// public static int FindElementByPosition(int[,] array, int x, int y)
//     {
//         return array[x - 1, y - 1];
//     }

// Проверка позиций на вхождение в массив
// public static bool ValidatePosition(int[,] array, int x, int y)
//     {
//         if (x <= 0 || x >= array.GetLength(0)) {
//             Console.WriteLine("Позиция по рядам выходит за пределы массива");
//             return false;
//         }
//         if (y <= 0 || y >= array.GetLength(1)) {
//             Console.WriteLine("Позиция по колонкам выходит за пределы массива");
//             return false;
//         }
//         return true;
//     }


// public static void PrintResult(int[,] numbers, int x, int y)
//     {
//         if (ValidatePosition(numbers, x, y)) {

// Console.WriteLine(FindElementByPosition(numbers, x, y));
//         }
//     }
