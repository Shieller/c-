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
    var result = 0;
    for (long i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            result += array[i];
        }
    }
    return result;
}
var array = createarray();
for (var i = 0; i < array.Length; i++)
    Console.WriteLine(array[i]);

Console.WriteLine(Check(array));