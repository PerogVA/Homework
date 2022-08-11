Console.WriteLine("Введите цифру от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 5)
{
  Console.WriteLine("нет");
}
else if (num > 5 && num <= 7)
{
  Console.WriteLine("да");
}
else
{
  Console.WriteLine("Число не входит в диапазон");
}
