// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.


char[,] charArray = {{'a','b'},{'c','d'}};
Console.WriteLine(CreateStringFrom2DArray(charArray));

string CreateStringFrom2DArray(char[,] charArray) 
{
    string result = "";
    foreach(char item in charArray) 
    {
        result += $"{item}";
    }
    return result;
}
        