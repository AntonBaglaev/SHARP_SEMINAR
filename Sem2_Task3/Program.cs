// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число
// кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.

// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int reminder = number1 % number2;

if (reminder == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет, " + reminder);
}