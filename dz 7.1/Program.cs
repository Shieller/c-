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
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = random.Next(0, 100);
        }
    }
    return array;
}

void Conclusion()
{
    var array = СreateArray();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
Console.WriteLine();
    }
}

Conclusion();
