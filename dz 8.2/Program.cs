// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] СreateArray(int m, int n)
{
    var random = new Random();
    var array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }
    return array;
}

int SumString(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}




Console.WriteLine("ВВедите колличество строк");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите клолличество столбцов");
int n = int.Parse(Console.ReadLine()!);

var array = СreateArray(m, n);

PrintArray(array);

int min = 0;
int sum = SumString(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int temp = SumString(array, i);
    if (sum > temp)
    {
        sum = temp;
        min = i;
    }
}
Console.WriteLine($"\n{min + 1}-я строкa");
