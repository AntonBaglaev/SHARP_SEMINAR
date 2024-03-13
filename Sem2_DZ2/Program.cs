// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки X и Y через пробел: ");
string[] coordinates = Console.ReadLine().Split('_');
int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);

if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("Точка находится на оси координат");
}