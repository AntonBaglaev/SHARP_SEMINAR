// Заполните массив на N (вводится ли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из массива. Старший разряд числа находится
// на 0-м индексе, младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231



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

int ArrayToNumber(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        num = 10 * num + arr[i];
    }
    return num;
}

Console.WriteLine("Введите размер массива, не более 8: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n < 1 || n > 8)
{
    Console.WriteLine("Задан некорректный размер массива");
    return;
}

int[] arr = CreateArrayRndInt(n, 0, 10);
PrintArray(arr);
int arrayToNum = ArrayToNumber(arr);
Console.Write(arrayToNum);