// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4    8 -> 2, 4, 6, 8

Console.WriteLine("Введите число > ");
string a = Console.ReadLine();
int n = Convert.ToInt32(a);

int count = 1;

while(count >= n);
{
    if(n % 2 == 0) 
    {
        Console.Write("-> ");
        Console.WriteLine(count);
        count = count - 1;
    }
    else 
    {
        count++;
    }
}
while(count <= n);
{
    if(n % 2 == 0) 
    {
        Console.Write("-> ");
        Console.WriteLine(count);
        count++;
    }
}