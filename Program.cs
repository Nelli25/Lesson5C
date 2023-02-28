// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int count = 0;
int[] arrayResult = new int[10];
int[] GetArray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999);
    return array;
}
void CountArray (int[] array)
{
    foreach (int el in array)
    {
        if (el % 2 == 0)
            count++;
    }
}
void PrintResult(int[] array, int count)
{
    Console.WriteLine($"Массив {string.Join("|", array)}");
    Console.WriteLine($"Количество четных чисел в массиве: {count}");
}
arrayResult = GetArray();
CountArray(arrayResult);
PrintResult(arrayResult, count);



//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
