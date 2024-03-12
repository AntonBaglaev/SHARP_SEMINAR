// Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого числа
// в степень, равную третьей цифре.

// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999 || number >= -999 && number <= -100)
{
    int secondDigit = number / 10 % 10;
    int numDegree = number % 10;
    int result = 1;
    int count = 0;
    while (count < numDegree)
    {
        result *= secondDigit; //result = result * secondDigit
        count++;
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ошибка ввода!");
}
