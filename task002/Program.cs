// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();


int[] array = NumbArray(10);
SummArray(array);

int[] NumbArray(int size)
{
  Console.ForegroundColor = ConsoleColor.Red;
  Console.Write("[");
  int[] arr = new int[size];
  for (int i = 0; i < size; i++)
  {
    arr[i] = new Random().Next(1, 10);
    Console.Write($"{arr[i]}, ");
  }
  Console.WriteLine("]");
  return arr;
}
void SummArray(int[] numb)
{
  int summ = 0;
  for (int i = 0; i < numb.Length; i += 2)
  {
    summ = summ + numb[i];
  }
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine($"Сумма чисел на не четных позициях -> {summ}");
}
Console.ForegroundColor = ConsoleColor.White;

