// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        
    return array;
}

void Show2dArray(double[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();        
    }
}

Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,]myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        
    return array;
}

void Show2dArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();        
    }
}


bool Zamena(int [,] array, int row, int col)
{      
    if (row < 0 || row > array.GetLength(0) - 1 || col < 0 || col > array.GetLength(1) - 1)    
    {
        Console.WriteLine("number not found");
        return false;
    }    
    Console.WriteLine($"value number = {array[row,col]}");
    return true;
        
}

Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("input a col: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,]myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
Zamena(myArray,row,col);
*/

// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
/*
int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        
    return array;
}

void Show2dArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();        
    }
}

void SrAr(int[,] array)
{   
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        Console.Write($"{ sum / array.GetLength(0)} ");
    }
}

Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("------------------------------");
int[,]myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
Console.WriteLine("------------------------------");
Console.Write("arithmetic mean: ");
SrAr(myArray);
*/
