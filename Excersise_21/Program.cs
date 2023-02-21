// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Please enter A coordinates:");
Console.Write("Ax = ");
int Ax = int.Parse(Console.ReadLine()!);
Console.Write("Ay = ");
int Ay = int.Parse(Console.ReadLine()!);
Console.Write("Az = ");
int Az = int.Parse(Console.ReadLine()!);

Console.WriteLine("Please enter B coordinates:");
Console.Write("Bx = ");
int Bx = int.Parse(Console.ReadLine()!);
Console.Write("By = ");
int By = int.Parse(Console.ReadLine()!);
Console.Write("Bz = ");
int Bz = int.Parse(Console.ReadLine()!);

Console.WriteLine("A(" + Ax + "," + Ay + "," + Az + ")");
Console.WriteLine("B(" + Bx + "," + By + "," + Bz + ")");

double dist = Math.Round(Math.Sqrt(Math.Pow((Bx-Ax),2) + Math.Pow((By-Ay),2) + Math.Pow((Bz-Az),2)),2);
Console.WriteLine("Distanation = " + dist);