// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

//Решение.

Console.Clear();

double[] array = new double[10];
NumbArray(array);
Console.WriteLine();
MasArray(array);


void NumbArray(double[] numb)
{
  Console.ForegroundColor = ConsoleColor.Red;
  Console.Write("[");
  for (int i = 0; i < numb.Length; i++)
  {
    numb[i] = new Random().Next(-10, 20);
    Console.Write(numb[i] + " ");
  }
  Console.WriteLine("]");
}

void MasArray(double[] number)
{
  double minNumb = 0;
  double maxNumb = 0;
  for (int i = 0; i < number.Length; i++)
  {
    if (number[i] < minNumb)
    {
      minNumb = number[i];
    }
    if (number[i] > maxNumb)
    {
      maxNumb = number[i];
    }
  }
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine($"Минимальное число {minNumb} Максимальное число {maxNumb}");
  Console.ForegroundColor = ConsoleColor.Yellow;
  Console.WriteLine($"{minNumb - maxNumb}");
}
Console.ForegroundColor = ConsoleColor.White;


