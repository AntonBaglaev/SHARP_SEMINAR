// На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.

// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

char[] StringToCharsArray(string str)
{
    char[] array = new char[str.Length];

    for (int i = 0; i < str.Length; i++)
    {
        array[i] = str[i];
    }
    return array;
}

void PrintArray(char[] array)
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

PrintArray(StringToCharsArray("Hello!"));