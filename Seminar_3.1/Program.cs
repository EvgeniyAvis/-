// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координаты точки A. X=");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Y=");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Z=");
double Az = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B. X=");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Y=");
double By = Convert.ToDouble(Console.ReadLine());
Console.Write("Z=");
double Bz = Convert.ToDouble(Console.ReadLine());


double distance = Math.Sqrt(Math.Pow((Ax - Bx), 2) + Math.Pow((Ay - By), 2) + Math.Pow((Az - Bz), 2));
Console.WriteLine($"Расстояние = {distance}"); 