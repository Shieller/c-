// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("ВВедите n ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите m");
int m= int.Parse(Console.ReadLine()!);

int Output(int n,int m)
{
int result = 0;
if (n<m){
for (int i = n+1; i<m; i++ ){
result+=i;
}
}
else {
    for (int i = m+1; i<n; i++ ){
result+=i;
}
}
return result;
}

int sum=Output(n,m);
Console.WriteLine(sum);