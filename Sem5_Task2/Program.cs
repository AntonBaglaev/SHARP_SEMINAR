// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.

// Пример
// 2 3 4 3
// 4 3 4 1 => 2 + 3 + 5 = 10
// 2 9 5 4

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)     // задаем двумерный массив
{
    int[,] matrix = new int[rows, columns];   
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)      // фиксируем строку массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // проходим по элементам строки массива
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)    //  вывод массива в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5}");

        }
        Console.WriteLine();
    }
}

int SumElemMainDiagonal(int[,] matrix)
{
    int result = 0;

    // int size = matrix.GetLength(0);                                        первый вариант
    // if(size > matrix.GetLength(1)) size = matrix.GetLength(1);
    

    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)  // второй вариант
    {
        result = result + matrix[i, i];
    }
    return result;
}

int[,] matrix = CreateMatrixRndInt(3,4,1,10);
PrintMatrix(matrix);

int sumMainDiagonal = SumElemMainDiagonal(matrix);
Console.WriteLine(sumMainDiagonal);