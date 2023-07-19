// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int ColChet(int[]array)
{
    int ColChet = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        ColChet = ColChet + 1;
    }
    return ColChet;
}
Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
Console.Write($"number of even numbers: {ColChet(myArray)}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int Nechet(int[]array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }    
    
    return sum;
}
Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
Console.Write($"Sum necehtnih = : {Nechet(myArray)}");
*/

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива. 
/*
Console.Write("input size array ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];

void RandArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void Array(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++) Console.Write(numbers[i] + " "); 
    Console.Write("]");
    Console.WriteLine();
}

RandArray(numbers);
Console.Write("array: ");
Array(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int n = 0; n < numbers.Length; n++)
{
    if (numbers[n] > max) max = numbers[n];  
    if (numbers[n] < min) min = numbers[n];    
}

Console.WriteLine($"Maximum = {max}, Minimum = {min}");
Console.WriteLine($"Maximum - Minimum = {max - min}");
*/
