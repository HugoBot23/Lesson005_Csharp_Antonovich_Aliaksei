// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Решение.

Console.Clear();
int[] array = new int[10];

NumbArray(array);
Console.WriteLine();
SumArray(array);

void NumbArray(int[] numb)
{
  int length = numb.Length;
  for (int i = 0; i < length; i++)
  {
    numb[i] = new Random().Next(100, 999);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"{numb[i]}, ");
  }
}

void SumArray(int[] summ)
{
  Console.ForegroundColor = ConsoleColor.Green;
  Console.Write("[");
  int count = 0;
  for (int i = 0; i < summ.Length; i++)
  {
    if (summ[i] % 2 == 0)
    {
      count++;
      Console.Write($"{summ[i]}, ");
    }
  }
  Console.Write("]");
  Console.WriteLine(" -> " + count);
}
Console.ForegroundColor = ConsoleColor.White;

