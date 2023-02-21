// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// * при N < 0, нужно вывести от N до -1
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Please enter Number:");
int n = int.Parse(Console.ReadLine()!);

Console.Write(n + " -> ");

for ( int i=1; i<=n; i++)
{    
    Console.Write(Math.Pow(i,3));
    if (i < n) Console.Write(", ");
}