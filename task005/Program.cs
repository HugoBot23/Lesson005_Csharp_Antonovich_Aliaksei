// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

//Решение.

Console.Clear();

int[] array1 = new int[10];
int[] array2 = new int[5];

NewArray(array1);
MultiplierArray(array1);
PrintArray(array2);

void NewArray(int[] res)
{
  Console.ForegroundColor = ConsoleColor.Yellow;
  Console.Write("[ ");
  for (int i = 0; i < res.Length; i++)
  {
    res[i] = new Random().Next(1, 10);
    Console.Write($"{res[i]} ");
  }
  Console.Write("]");
}

void MultiplierArray(int[] res)
{
  for (int i = 0; i < res.Length / 2; i++)
  {
    int numb = res[i];
    array2[i] = res[i] * res[res.Length - 1 - i];
    res[res.Length - 1 - i] = numb;
  }
}

void PrintArray(int[] res)
{
  Console.ForegroundColor = ConsoleColor.Green;
  Console.Write(" -> [ ");
  Console.Write($"{String.Join(", ", res)} ");
  Console.Write("] Произведение.");
}
Console.ForegroundColor = ConsoleColor.White;