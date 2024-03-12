// Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.

// Примеры
// a = 256 => 26
// a = 891 => 81

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999 || number >= -999 && number <= -100)
{
    int firstDigit = number / 100; // 256 / 100 = 2.56 => 2
    int thirdDigit = number % 10;  // 256 % 10 = 250 + 6 => 6
    int result = firstDigit * 10 + thirdDigit;

    Console.Write(" => " + result);
}
else
{
    Console.WriteLine("Ошибка ввода!");
}
