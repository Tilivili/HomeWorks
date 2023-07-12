// Задача 19 Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.
//1 решение
/*
bool IsFiveDigit(int number)
{
    if (number / 10000 == number % 10 & number / 1000 % 10 == number % 100 / 10 ) return true;
    else return false;
}

Console.Write("input number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = IsFiveDigit(number);
Console.WriteLine(result);
*/

//2 решение
/*
Console.Write("Enter number ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 100000) 
{
	if (number / 10000 == number % 10 & number / 1000 % 10 == number % 100 / 10 ) Console.Write("palindrom");
    else Console.Write("nePalindrom");
} 
else Console.Write("the number is not five-digit");
*/

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
/*
double Distans(int x1, int y1, int z1, int x2, int y2, int z2) 
{
    double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return result;
}
Console.Write("Input x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.Write(Distans (x1, y1, x2, y2, z1, z2));
*/

//Задача 23 Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int cube)
{
    int count = 1;
    while (count <= cube)
    {
        Console.WriteLine($"{count} - {count * count * count}");
        count++;
    }
}

Console.Write("Input Number: ");
int cube = Convert.ToInt32(Console.ReadLine());

Cube(cube);
*/
