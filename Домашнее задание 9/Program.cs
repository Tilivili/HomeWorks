// Задача 64: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

/*
void ShowNums(int num)
{
    Console.Write(num + " "); 
    if (num > 1) ShowNums(num - 1);
}

Console.Write("input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNums(num);
*/

// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int Sum(int m, int n)
{
    if (m <= n && m != 0) 
    {
        return m + Sum(m + 1,n);
    }
    else return 0;
}
Console.Write("input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(m,n));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
/*
int Aker(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(n == 0)
    {
        return Aker(m - 1, 1);
    }
    else
    {
        return Aker(m - 1,Aker(m,n - 1));
    }
}

Console.Write("input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Aker(m,n));
*/