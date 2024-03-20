// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

int MIN = 1;
int MAX = 9;

int randSizeArray = new Random().Next(5, 10);

int[] array = GetArrayWithRandomValue(randSizeArray);

Console.WriteLine("Оригинальный массив:");
System.Console.WriteLine(PrintArray(array));

Console.WriteLine("Перевернутый массив:");
Console.WriteLine(PrintArray(ReversItemInArray(array)));

int[] GetArrayWithRandomValue(int size) 
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) {
        array[i] = new Random().Next(MIN, MAX);
    }
    return array;
}

string PrintArray(int[] array) 
{
    string result = "";
    foreach(int item in array) {
        result = result + item + " ";
    }
    return result;
}

int[] ReversItemInArray(int[] array) 
{
    int temp = 0;
    for(int i = 0; i < (int) array.Length / 2; i++) {
        temp = array[i];
        array[i] = array[array.Length-1 - i];
        array[array.Length-1 - i] = temp;
    }
    return array;
}