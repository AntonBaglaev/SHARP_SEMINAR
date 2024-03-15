// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.

// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

// int[] array = new int[6] {1, 3, 2, 4, 2, 3};
int[] array = new int[7] {1, 3, 2, 4, 2, 3, 9};

int[] resultArray = new int[array.Length/2];

// заполнение нового массива
for(int i = 0; i < array.Length/2; i++)
{
    resultArray[i] = array[i] * array[array.Length - 1 - i];
}

// вывод нового массива
for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write(resultArray[i] + " ");
}