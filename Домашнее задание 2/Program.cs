//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
/*
int CutNumber(int num)
{
    int num1 = num % 100;
    int num2 = num1 / 10;
    int result = num2;
    return result;
}
Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNumber = CutNumber(num); 
Console.WriteLine($"New version number of {num} is {newNumber}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
/*
int ThirdDigit(int num)     
{
    int result = -1;
    if (num < 100)
    {
        Console.Write("there is no third number ");
    }
    else
    {
        while (num > 999)
        {
            num = num / 10;
        }
        result = num % 10;
    }
    return result;
}
Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNumber = ThirdDigit(num); 
Console.WriteLine($"New version number of {num} is {newNumber}");
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Write("Enter a day of week ");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day >= 1 && Day <=7) 
{
	if (Day >= 6) Console.Write("holiday");
    else Console.Write("Work!");
} 
else Console.Write("there are only 7 days in a week");
*/