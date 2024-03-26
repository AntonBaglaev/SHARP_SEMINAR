// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string input = "Hello World";
Console.WriteLine(GetReversWords(input));

static string GetReversWords(string input) 
{
    string[] words = input.Split(' ');
    Array.Reverse(words);
    string result = "";
    foreach(string item in words) {
        result += $"{item}" + " ";
    }
    return result.Trim();
}