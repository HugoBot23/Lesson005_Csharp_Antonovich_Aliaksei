// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

//Решение.
Console.Clear();

int[] array = GetArray(123, 1, 50);

MasArray(array);
Console.WriteLine();

int[] GetArray(int size, int minNumber, int maxNumber)
{
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(minNumber, maxNumber + 1);
    Console.Write($"{array[i]} ");
  }
  return array;
}

void MasArray(int[] res)
{
  int count = 0;
  for (int i = 0; i <= res.Length; i++)
  {
    if ((i > 10) && (i <= 99))
    {
      count++;
    }
  }
  Console.ForegroundColor = ConsoleColor.Green;
  Console.Write(" ");
  Console.Write($"Количество элементов от 10 до 99 -> {count}");
}
Console.ForegroundColor = ConsoleColor.White;