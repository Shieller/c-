//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число");
var n = int.Parse(Console.ReadLine()!);
int c = 0;
while (n > 0)
{
    c = c + (n % 10);
    n = n / 10;
}
Console.WriteLine(c);