//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
// В задании написанно массив из 8-ми элеменов а в приерах разные размерности, сделал как в примерах 

Console.WriteLine("Введите кол-во элементов массива");
var col = int.Parse(Console.ReadLine()!);

int[] array = new int[col];
for (int i = 0; i < col; i++)
{
    array[i] = new Random().Next(0, 50);
}
for (int i = 0; i < col; i++)
{
    Console.WriteLine(array[i]);
}