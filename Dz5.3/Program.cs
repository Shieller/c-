//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

int[] createarray()
{
    Console.WriteLine("ВВедите размерность массива");
    var n = int.Parse(Console.ReadLine()!);
    var random = new Random();
    var array = new int[n];
    for (long i = 0; i < n; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}
int Check(int[] array)
{
    var max = 0;
    var min = 100;
    for (long i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return (max - min);
}
var array = createarray();
for (var i = 0; i < array.Length; i++)
    Console.WriteLine(array[i]);

Console.WriteLine(Check(array));