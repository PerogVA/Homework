// 34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
int[] CreateArrayRndInt(int size, int min, int max)
{
  int[] array = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < size; i++)
  {
    array[i] = rnd.Next(min, max + 1);
  }
  return array;
}
void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}
int[] arr = CreateArrayRndInt(12, -999, 1000);
PrintArray(arr);
int EvenNombers(int[] array)
{ 
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      count++;
    }
  }
  return count;
}
int result = EvenNombers(arr);
Console.Write(result);
