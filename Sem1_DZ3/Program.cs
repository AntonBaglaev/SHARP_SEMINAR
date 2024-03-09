// Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("Введите число");

string number = Console.ReadLine();
int number1 = int.Parse(number);


if (number1 % 2 == 1)
{
    Console.WriteLine($"Число {number1} является нечетным");
}
else
{
    Console.WriteLine($"Число {number1} является четным");
}


// ответ для автотеста

// if ((number % 2) == 0)
//         {
//             Console.WriteLine($"четное");
//         }
//         else
//         {
//             Console.WriteLine($"нечетное");
//         }