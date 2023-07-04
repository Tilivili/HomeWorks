// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт большее число.
Console.Write("input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2) Console.WriteLine(num1);
else Console.WriteLine(num2);