int[] createarray()
{
    Console.WriteLine("Напишите размерность массива");
    var k = int.Parse(Console.ReadLine()!);
    var Random = new Random();
    var result = new int[k];
    for (long i = 0; i < k; i++)
    {
        result[i] = Random.Next(100, 1000);
    }
    return result;
}
int Chet(int[] array)
{
    var result = 0;
    for (long i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result += 1;
        }

    }
    return result;
}

var array = createarray();

for (var i = 0; i < array.Length; i++)
    Console.WriteLine(array[i]);

Console.WriteLine(Chet(array));