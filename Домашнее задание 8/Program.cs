// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
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
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
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

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
Sort(myArray);
Console.WriteLine("-----------------------");
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
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
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void LineNumberMin(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} string");
}
Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
LineNumberMin(myArray);
*/

// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
/*
int[,] CreateRandomFirstMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,]matrix1 = new int[rows,columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            matrix1[i, j] = new Random().Next(minValue, maxValue + 1);
    return matrix1; 
}

int[,] CreateRandomSecondMatrix(int rows2, int columns2, int minValue2, int maxValue2)
{
    int[,]matrix2 = new int[rows2,columns2];
    for (int x = 0; x < rows2; x++)
        for (int y = 0; y < columns2; y++)
            matrix2[x, y] = new Random().Next(minValue2, maxValue2 + 1);
    return matrix2; 
}

void ShowMatrix1(int[,] matrix1)

{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
            Console.Write(matrix1[i, j] + " ");

        Console.WriteLine();
    }
}

void ShowMatrix2(int[,] matrix2)

{
    for (int x = 0; x < matrix2.GetLength(0); x++)
    {
        for (int y = 0; y < matrix2.GetLength(1); y++)
            Console.Write(matrix2[x, y] + " ");

        Console.WriteLine();
    }
}

int[,] Product(int[,] matrix1, int[,] matrix2)
{
    if(matrix1.GetLength(1) != matrix2.GetLength(0)) Console.WriteLine("Product not found");
    int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix2.GetLength(0); k++)
                    {
                        product[i,j] += matrix1[i,k] * matrix2[k,j];
                    }
                }
            }
            return product;

}

 void Print(int[,] matrix3)
        {
            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix3[i, j]);
                }
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

Console.Write("input a number of rows2: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns2: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min2 possible value: ");
int minValue2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max2 possible value: ");
int maxValue2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = CreateRandomFirstMatrix(rows, columns, minValue, maxValue);
int[,] matrix2 = CreateRandomSecondMatrix(rows2, columns2, minValue2, maxValue2);
int[,] product = Product(matrix1, matrix2);
ShowMatrix1(matrix1);
Console.WriteLine("--------------------------");
ShowMatrix2(matrix2);
Console.WriteLine("--------------------------");
Console.WriteLine("product = matrix1 * matrix2: ");
Print(product);  
*/
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
/*
int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);

void PrintIndex(int[,,] array)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += count;
                count += 3;
            }
        }
    }
}
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int len = 4;
int[,] table = new int[len, len];
Spiral(table, len);
PrintArray(table);

void Spiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
*/