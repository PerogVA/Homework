// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое число M");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число N");
int number2 = Convert.ToInt32(Console.ReadLine());
int SumNatureNumber(int num,int num2)
{
  int sum = 0;
  if (num < num2) 
 {
  sum = num + SumNatureNumber(num + 1,num2);
 }
 if (num > num2)
 {
  sum = num + SumNatureNumber(num - 1, num2);
 }
 if (num == num2)
 {
  sum += num;
 }
 return sum;
}

int result = SumNatureNumber(number,number2);
Console.WriteLine($"Сумма чисел равна {result}");