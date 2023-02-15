// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

//Решение.
Console.Clear();

int[] array = GetArray(10);
Console.WriteLine();
FlippingArray(array);
PrintArray(array);

int[] GetArray(int size)
{
  Console.ForegroundColor = ConsoleColor.Yellow;
  Console.Write("[ ");
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(-5, 5);
  }
  Console.Write($"{String.Join(", ", res)} ");
  Console.Write("]");
  return res;
}

void FlippingArray(int[] res)
{
  for (int i = 0; i < res.Length; i++)
  {
    res[i] = res[i] * -1;
  }
}

void PrintArray(int[] res)
{
  Console.ForegroundColor = ConsoleColor.Green;
  Console.Write("[ ");
  Console.Write($"{String.Join(", ", res)} ");
  Console.Write("]");
}
Console.ForegroundColor = ConsoleColor.White;