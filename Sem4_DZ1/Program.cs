// Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого четная.

    string inString = GetDataFromConsole();

    while(true)
    {
        if(isExit(inString) || isEvenSumValue(inString))
        {
            Console.WriteLine("[STOP]");
            Environment.Exit(0);
        }
        inString = GetDataFromConsole();
    }


string GetDataFromConsole() 
{
    Console.Write("Введите число: ");
    string? inValue = Console.ReadLine();
    if(inValue == null) inValue = "";
    return inValue;
}

int ConvertStringToNumber(string number) 
{
    try
    {
        return Convert.ToInt32(number);
    } 
    catch (Exception)
        {
        System.Console.WriteLine("Введеное значение не ядляется числом. Попробуйте снова.");
    }
    return -1;
}

bool isExit(string str) 
{
    if(str.Contains('q')) 
    {
    return true;
    }
    return false;
}

bool isEvenSumValue (string str) 
{
    int sum = 0;
    string[] array = str.Split(' ');
    foreach(string item in array) 
    {
        sum += ConvertStringToNumber(item);
    }
    return sum % 2 == 0;
}