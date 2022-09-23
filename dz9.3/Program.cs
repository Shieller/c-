
Console.WriteLine("ВВедите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите n");
int n = int.Parse(Console.ReadLine()!);

int rez = Akkerman(m, n);

Console.Write(rez);

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}