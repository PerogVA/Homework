// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] CreateArrayRndInt(int size, int min, int max)
{
  double[] array = new double[size];
  Random rnd = new Random();
  for (int i = 0; i < size; i++)
  {
    array[i] = rnd.Next(min, max) + rnd.NextDouble();
  }
  return array;
}
void PrintArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}
double[] arr = CreateArrayRndInt(5, 5, 10);
PrintArray(arr);
double SumNombers(double[] array)
{
  double min1 = array[0];
  double max1 = array[0];

  for (int i = 0; i < array.Length; i++)
  {
    if (min1 > array[i])
    {
      min1 = array[i];
    }
    if ( max1 < array[i])
    {
      max1 = array[i];

    }
  }
    return max1 - min1;
  
}
double result = SumNombers(arr);
Console.Write(result);