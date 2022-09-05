// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.Clear();
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
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}
bool CheckNumbInMassive(int[,] array)
{
    Console.WriteLine("ВВедите число которе хотите проверить");
    var n = int.Parse(Console.ReadLine()!);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == n)
            {
                return true;
            }
        }
    }
    return false;
}

void Conclusion()
{
    var array = СreateArray();
    bool result = CheckNumbInMassive(array);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

    if (result == true)
    {
        Console.WriteLine("Ваше число есть в массиве");
    }
    else
    {
        Console.WriteLine("Вашего числа нету");
    }

}
Conclusion();
