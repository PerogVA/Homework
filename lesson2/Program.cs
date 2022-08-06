Console.WriteLine("Введите 3 числа");
int x= Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
if (x >= y && x >= z)
{
  Console.WriteLine($"max , {x} " );
}
else if (y >= x && y >=z )
{
  Console.WriteLine( $"max {y}"  );
}
else if (z >= x && z >= y)
{
  Console.WriteLine( $"max {z}" );
}

