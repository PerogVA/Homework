// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.WriteLine("Введите 2 числа ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int resalt = num;
for (int i = 1; i <= num2; i++ )
{
resalt = resalt * num;
}
Console.WriteLine(resalt);



