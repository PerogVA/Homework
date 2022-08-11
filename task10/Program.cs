Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
num = num / 10;
Console.WriteLine ($"Вторая цифра равна: {num%10}");
