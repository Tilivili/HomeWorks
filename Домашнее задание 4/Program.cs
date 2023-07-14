//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
/*
double Stepen(int num1, int num2) 
{
    double result = Math.Pow(num1, num2);
    return result;
}

Console.Write("input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write(Stepen (num1, num2));
*/

//Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
/*
Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int len = Length(num);
Console.Write($"the sum of digits in a number = {Sum(num,len)}");

int Length(int num)
{
int index = 0;
while (num > 0)
{
num = num / 10;
index++;
}
return index;
}
int Sum(int num, int len)
{
int sum = 0;
for (int i = 0; i < len; i++)
{   
sum = sum + (num % 10);
num = num / 10;
}
return sum;
}
*/

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// Разработать метод CreateArray(int size), генерирующий массив
// на основе данных, вводимых пользователем.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"input {i} number of array ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);
*/