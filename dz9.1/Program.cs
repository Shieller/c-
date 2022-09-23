// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("ВВедите n ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите m");
int m= int.Parse(Console.ReadLine()!);

void Output(int n,int m)
{
if (n<m){
for (int i = n+1; i<m; i++ ){
Console.Write(i+" ");
}
}
else {
    for (int i = m+1; i<n; i++ ){
Console.Write(i+" ");
}
}

}


Output(n,m);
