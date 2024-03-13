// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Число кратно и 7, и 23 ");
}
else if (number % 7 == 0)
{
   Console.WriteLine("Число кратно только 7"); 
}
else if (number % 23 == 0)
{
    Console.WriteLine("Число кратно только 23"); 
}
else
{
    Console.WriteLine("Число не кратно ни 7, ни 23");
}