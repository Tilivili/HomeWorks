// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт большее число.
/*
Console.Write("input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2) Console.WriteLine(num1);
else Console.WriteLine(num2);
*/

//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
/*
Console.Write("input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.Write("max = ");
Console.WriteLine(max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0) Console.WriteLine("Yes");
else Console.WriteLine("no");
*/


//Задача 8: Напишите программу, которая на вход принимает число (Number),
// а на выходе показывает все чётные числа от 1 до Number.
/*
Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
int max = num;
while (i <= num)
{
    if (i % 2 == 0) 
    {
    Console.WriteLine(i);
    }
    i++;
}
*/
