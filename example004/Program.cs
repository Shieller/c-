Console.WriteLine("Введите пятизначное число");
string? n = Console.ReadLine();

  if (n?[0]==n?[4] && n?[1]==n?[3]){
    Console.WriteLine("число палиндром.");
  }
  else Console.WriteLine("не палиндром.");
