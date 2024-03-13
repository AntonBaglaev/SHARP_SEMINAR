// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.Write("Введите любое натуральное число: ");
int b = Convert.ToInt32(Console.ReadLine());
int e = b;
int i1 = 1;
int i2 = 1;
int l1 = b;
string g = "";

if (e < 10)
{
    Console.Write(e);
}
else if (e > 9)
{
    while (e > 0)
    {
        int d = e % 10;
        e = e / 10;
        g = g + d;
        i1 = i1 + 1;
    }
    int s = Convert.ToInt32(g);
    while (i2 < i1)
    {
        int v = s % 10;
        s = s / 10;
        i2 = i2 + 1;
        l1 = l1 / 10;
        if (l1 > 0)
        {
            Console.Write(v + ",");
        }
        else
        {
            Console.Write(v);
        }
    }
}


// Console.WriteLine("Введите натуральное число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 10)
// {
//     Console.WriteLine(number);
// }
// else
// {
//     while (number > 0)
//     {
//         int currentDigit = number % 10;
//         number /= 10;
//         if (number > 0)
//         {
//             Console.Write(currentDigit + ",");
//         }
//         else
//         {
//             Console.WriteLine(currentDigit);
//         }
//     }
// }