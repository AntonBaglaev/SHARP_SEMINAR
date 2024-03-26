// Задайте произвольную строку. Выясните, является ли она палиндромом.

string input = "Поп";
Console.WriteLine(isPalendrom(input));

bool isPalendrom(string input) 
{
    return input.ToLower().SequenceEqual(input.ToLower().Reverse());
}