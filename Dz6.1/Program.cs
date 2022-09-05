//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

int[] СreateArray()
{
    Console.WriteLine("ВВедите размерность массива M");
    var n = int.Parse(Console.ReadLine()!);
    var random = new Random();
    var array = new int[n];
    Console.WriteLine("ВВедите числа");
    for (long i = 0; i < n; i++)
    {
        var m = int.Parse(Console.ReadLine()!);
        array[i] = m;
    }
    return array;
}

int CheckPositiveNumb(int[] array)
{
    var count = 0;
    for (long i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;

        }
    }
    return (count);
}
int Conclusion()
{
    var array = СreateArray();
    for (var i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);

    Console.WriteLine(CheckPositiveNumb(array));
    return 0;
}

var result = Conclusion();