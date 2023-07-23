//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Input size: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[m];

void mas(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"input {i+1} massive elements");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }

}

int kol(int[] Array)
{
    int i=0;
    int sum = 0;
    while (i < Array.Length)
        {
            if(Array[i]>0)
            sum = sum + 1;
            i = i + 1;
        }
    return sum;
}

mas(m);
Console.Write($"Number > 0 : {kol(Array)}");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.Write("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double x=(double)(b2-b1)/(k1-k2);
double y=(double)(k1*(b2-b1))/(k1-k2)+b1;
if (k1 == k2 && b2 != b1) Console.Write(" straight lines are parallel");
else if (k1 == k2 && b1 == b2) Console.Write(" straight lines match");
else Console.Write($" the lines intersect at a point ({x},{y})");
*/






 


