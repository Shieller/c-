//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

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
            array[i,j] = random.Next(0, 100);
        }
    }
    return array;
}

int Conclusion()
{
    var array = СreateArray();
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
