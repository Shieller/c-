Console.WriteLine("Введите пятизначное число");
string? numberstring = Console.ReadLine();
int n = int.Parse(numberstring!);
for (int i=1; i < n+1; i++){
    Console.WriteLine(i*i*i);
}
 