// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int MIN = 100;
int MAX = 999;

int randSizeArray = new Random().Next(5, 10);

int[] array = GetArrayWithRandomValue(randSizeArray);

Console.WriteLine("Оригинальный массив:");
System.Console.WriteLine(PrintArray(array));

Console.WriteLine("Количество чётных элементов массива:");
Console.WriteLine(GetCountEvenValue(array));

int[] GetArrayWithRandomValue(int size) 
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++) {
        array[i] = new Random().Next(MIN, MAX);
    }
    return array;
}

int GetCountEvenValue(int[] array) 
{
    int count = 0;
    foreach(int item in array) {
        if(item % 2 == 0) count++;
    }
    return count;
}

string PrintArray(int[] array) 
{
    string result = "";
    foreach(int item in array) {
        result = result + item + " ";
    }
    return result;
}