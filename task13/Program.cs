// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.

Console.WriteLine("Введите цифру ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int num1 = num;
while (num1 > 0)
{
  num1 = num1 / 10;
  count++;
}
if (count < 3)
{

  Console.WriteLine("Нет третьей цифры ");
}
else
{
  while (count > 3)
  {
    num = num / 10;
    count--;
  }
  Console.WriteLine($"третья цифра {num % 10}");
}