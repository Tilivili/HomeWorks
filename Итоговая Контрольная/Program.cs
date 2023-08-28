/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив
из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.*/

// Функция из открытых источников для генерации случайных строк
Random random = new Random();
string RandomString(int length)
{
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
}

// Собственная реализация
string[] CreateRandomArray(int size, int minValue, int maxValue)
{
    string[] array = new string[size];

    for(int i = 0; i < size; i++)
    {
        int r =  random.Next(minValue, maxValue + 1);
        array[i] = RandomString(r);
    }
    return array;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[]Copy(string[]array)
{   
    int count = 0;
    string[]arr = new string [array.Length];
    for(int i = 0; i < array.Length; i++)
    {  
      if(array[i].Length <= 3) 
        {
        arr[count] = array[i];
        count++;
        } 
    }
    return arr;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

string[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
Console.WriteLine("------------------------------");
string[]copy = Copy(myArray);
ShowArray(copy);


