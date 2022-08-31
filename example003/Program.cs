
Console.WriteLine("Введите число которое хотите возвести в степень");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень в котору надо возвести");
int y = int.Parse(Console.ReadLine()!);

int result = x;

for (int i = 1; i < y; i++)
{
    result = result * x;
}
Console.WriteLine(result);

