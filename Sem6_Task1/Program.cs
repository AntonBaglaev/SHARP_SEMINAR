// Задайте массив символов (тип char []). Создайте строку из символов этого массива.
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

static string ArrayCharsToString(char[] chars)
{
    string str = string.Empty;

    for (int i = 0; i < chars.Length; i++)
    {
        str += chars[i]; // str = str + chars[i]
    }

    return str;
}

char[] chars = { 'a', 'b', 'c', 'd' };

string str = ArrayCharsToString(chars);

Console.WriteLine(str);

