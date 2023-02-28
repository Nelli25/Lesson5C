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
    Console.WriteLine($"Массив 1: {string.Join("|", array)}");
    Console.WriteLine($"Количество четных чисел в массиве: {count}");
}
arrayResult = GetArray();
CountArray(arrayResult);
PrintResult(arrayResult, count);


//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int sum = 0;
int[] arrayRes = new int[4];
int[] MyArray()
{
    int[] array2 = new int[4];
    for (int i = 0; i < array2.Length; i++)
        array2[i] = new Random().Next(-100, 100);
    return array2;
}
void SumArray (int[] array2)
{
    for (int i = 0; i < array2.Length; i+=2)
    {
       sum += array2[i];
    }
}
void PrintRes(int[] array2, int sum)
{
    Console.WriteLine($"Массив 2: {string.Join("|", array2)}");
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");
}
arrayRes = MyArray();
SumArray(arrayRes);
PrintRes(arrayRes, sum);

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double diff = 0;
double[] arrayResult3 = new double[6];
double[] NewArray()
{
    double[] array3 = new double[6];
    for (int i = 0; i < array3.Length; i++)
        array3[i] = new Random().Next(-100, 100);
    return array3;
}
void DiffArray (double[] array3)
{
    for (int i = 0; i < array3.Length; i++)
    {
       diff = array3.Max() - array3.Min();
    }
}
void PrintResult3(double[] array3, double diff)
{
    Console.WriteLine($"Массив 3: {string.Join("|", array3)}");
    Console.WriteLine($"Hазница между максимальным и минимальным элементов массива: {diff}");
}
arrayResult3 = NewArray();
DiffArray(arrayResult3);
PrintResult3(arrayResult3, diff);
