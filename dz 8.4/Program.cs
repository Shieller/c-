Console.WriteLine("ВВедите x ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите y");
int y= int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите z");
int z = int.Parse(Console.ReadLine()!);

int[,,] array = new int[x, y, z];
СreateArray(array);
PrintArray(array);


void СreateArray(int[,,] array)
{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[x, y, z] = temp[count];
        count++;
      }
    }
  }
}


void PrintArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

