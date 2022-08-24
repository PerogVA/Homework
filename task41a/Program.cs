Console.WriteLine("Сколько чисел Вы хотите ввести: ");
int num1 = Convert.ToInt32(Console.ReadLine());
string CountEven(int num)
{ 
int count = 0;
for (int i = 0; i < num; i++)
{
  Console.WriteLine($"Введите число {i + 1}: ");
  int num2 = Convert.ToInt32(Console.ReadLine());
  if (num2 > 0)
    count++;
}
return "Количество положительных чисел: " + count;
}
if (num1 < 1) Console.WriteLine("Введите положительное число");
else Console.WriteLine(CountEven(num1));
