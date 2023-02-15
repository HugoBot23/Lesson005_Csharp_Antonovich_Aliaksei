// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного 
// копирования.

//Решение.

Console.Clear();

int[] array = new int[10];
int[] array1 = new int[10];

GetArray(array);
Console.WriteLine();
CopyingArray(array);
PrintArray(array1);

void GetArray(int[] res)
{
  Console.ForegroundColor = ConsoleColor.Yellow;
  Console.Write("[");
  for (int i = 0; i < res.Length; i++)
  {
    res[i] = new Random().Next(1, 20);
  }
  Console.Write(String.Join(" ", array));
  Console.Write("]");
}

void CopyingArray(int[] res)
{
  for (int i = 0; i < res.Length; i++)
  {
    array1[i] = array[i];
  }
}

void PrintArray(int[] res)
{
  Console.ForegroundColor = ConsoleColor.Green;
  Console.Write("[");
  Console.Write(String.Join(" ", array1));
  Console.Write("]");
}
Console.ForegroundColor = ConsoleColor.White;