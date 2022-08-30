
Console.WriteLine("Введите цифру от 1 до 7");
string? numberstring = Console.ReadLine();
int n = int.Parse(numberstring!);

if(n>5 & n<8)
{
Console.WriteLine("Да");
}
else if (n<5 & n>0)
{
   Console.WriteLine("Нет"); 
}
else
{
    Console.WriteLine("Неправельный ввод");
}
