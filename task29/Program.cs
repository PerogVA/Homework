// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.Write("[");
int[] CreateArray()

{
  int[] array = new int[8];
  for (int i = 0; i < 8; i++)
  {
    array[i] = new Random().Next(0, 100);
  }


  return array;
}
int[] array = CreateArray();
void PrintArray()
{
  for (int i = 0; i < 8; i++)
  {
    Console.Write($" {array[i]}");
  }
}
PrintArray();
Console.Write("]");