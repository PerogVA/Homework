﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
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
int[] arr = CreateArrayRndInt(5, 5, 10);
PrintArray(arr);
int SumNombers(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (i % 2 != 0)
    {
      sum = sum + array[i];
    }
  }
  return sum;
}
int result = SumNombers(arr);
Console.Write(result);
