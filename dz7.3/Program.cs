//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
int[,] СreateArray()
{
    Console.WriteLine("ВВедите размерность массива m");
    var m = int.Parse(Console.ReadLine()!);
    Console.WriteLine("ВВедите размерность массива m");
    var n = int.Parse(Console.ReadLine()!);
    var random = new Random();
    var array = new int[m, n];
    for (long i = 0; i < m; i++)
    {
        for (long j = 0; j < n; j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}
int AverageValue(int[,] array)
{
double result = 0;
    Console.Write("Среднее арифметическое каждого столбца : ");
    for (long i = 0; i < array.GetLength(1); i++)
    {
        for (long j = 0; j < array.GetLength(0); j++)
        {
            result+=array[j,i];
        }
    Console.Write(result/array.GetLength(0)+ "; ");
    result = 0;
    }
Console.WriteLine();
return 0;
}

int Conclusion()
{
    var array = СreateArray();
    var result = AverageValue(array);
    for (long i = 0; i < array.GetLength(0); i++)
    {
        for (long j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return 0;
}
var result = Conclusion();
