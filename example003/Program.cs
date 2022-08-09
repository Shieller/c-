Console.WriteLine("ВВедите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура маша");

}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
