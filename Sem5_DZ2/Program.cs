// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Пример

// |4|3|1| => |4|6|2|
// |2|6|9| => |2|6|9|
// |4|6|2| => |4|3|1|

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++) // matrix.GetLength(0)
    {
        for (int j = 0; j < colums; j++) // matrix.GetLength(1)
        {
            matrix[i, j] = rnd.Next(min, max);
            //matrix[i,j] = i+j;  
        }
    }
    return matrix;
}

void PrintMatrixInt(int[,] arr) //Метод, который выводит массив
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],5} "); // формат вывода в 5 символов
        }
        Console.WriteLine();
    }

}

void SwapMatrixFirstLastRow(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
}

int[,] rndMatrix = CreateMatrixRndInt(4, 5, 0, 10);
PrintMatrixInt(rndMatrix);
SwapMatrixFirstLastRow(rndMatrix);
Console.WriteLine();
PrintMatrixInt(rndMatrix);

// ответ на автотест

// Печать массива
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

//  Обмен первой с последней строкой
// int[,] SwapFirstLastRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         SwapItems(array, i);
//     }
//     return array;
// }

// Обмен элементами массива
// void SwapItems(int[,] array, int i)
// {
//     int temp = array[0, i];
//     array[0, i] = array[array.GetLength(0) - 1, i];
//     array[array.GetLength(0) - 1, i] = temp;
// }


// void PrintResult(int[,] numbers)
// {
//     PrintArray(SwapFirstLastRows(numbers));
// }