
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("ВВедите колличество строк 1-й матрицы");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите клолличество столбцов 1-й матрицы (и кол-во строк во 2-й");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите клолличество столбцов 2-й матрицы ");
int k = int.Parse(Console.ReadLine()!);

int[,] array1 = new int[m, n];
СreateArray(array1);
Console.WriteLine("первая матрица:");
PrintArray(array1);

int[,] array2 = new int[n, k];
СreateArray(array2);
Console.WriteLine("Вторая матрица");
PrintArray(array2);

int[,] result = new int[m, k];

Multiply(array1, array2, result);
Console.WriteLine("Произведение = ");
PrintArray(result);

void СreateArray(int[,] array)
{
    var random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }
}

void Multiply(int[,] array1, int[,] array2, int[,] result)
{
    int sum = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int l = 0; l < result.GetLength(1); l++)
            {
                sum+=array1[i,l] * array2[l,j];
            }
        result[i,j]= sum;
        }
    }
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

