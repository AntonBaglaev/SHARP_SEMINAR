// Задайте масс х целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3] => 2


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }

    }
    Console.Write("]");
}

int NumberCountCheck(int[] arr, int lastDigit, int multiple)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 10 == lastDigit && arr[i] % multiple == 0) count++;
    }
    return count;
}

Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArrayRndInt(n, 1, 100);
PrintArray(newArray);
Console.WriteLine();
Console.WriteLine(NumberCountCheck(newArray, 1, 7));