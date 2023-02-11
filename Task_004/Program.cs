// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4    8 -> 2, 4, 6, 8

Console.WriteLine("Введите число > ");
var n = Console.ReadLine();
Console.Write("-> ");

int count = 1;
int index = 0;
int a = 0;
var chet = long.Parse(n) / 2;

while(index < chet)
{
    a = a + 2;
    Console.Write(a);
    Console.Write(", ");
    index = index + 1;
}
if(index == 0)
    Console.WriteLine("Чётных чисел нет");
    count = count + 1;
