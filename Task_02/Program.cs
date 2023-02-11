// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7 44 5 78 -> 78 22 3 9 -> 22

Console.WriteLine("Введите первое число > ");
var a = Decimal.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число > ");
var b = Decimal.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число > ");
var c = Decimal.Parse(Console.ReadLine());

var max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("-> ");
Console.WriteLine(max);