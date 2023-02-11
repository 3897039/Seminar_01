// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7; a = 2 b = 10 -> max = 10 a = -9 b = -3 -> max = -3 

Console.WriteLine("Введите первое число > ");
var a = Decimal.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число > ");
var b = Decimal.Parse(Console.ReadLine());

if (a > b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
    Console.Write("min = ");
    Console.WriteLine(b);
}
else 
{
    Console.Write("max = ");
    Console.WriteLine(b);
    Console.Write("min = ");
    Console.WriteLine(a);
}


