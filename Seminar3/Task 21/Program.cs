/* Задача 21
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
double Distance3D (int coordX1, int coordY1, int coordZ1, 
                   int coordX2, int coordY2, int coordZ2)
{
double res = 0;
res = Math.Sqrt(Math.Pow(coordX1 - coordX2, 2) + Math.Pow(coordY1 - coordY2, 2) + Math.Pow(coordZ1 - coordZ2, 2));
return Math.Round(res, 2);
}

Console.Write("Enter a coordinate x for the first point A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a coordinate y for the first point A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a coordinate z for the first point A: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a coordinate x for the second point B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a coordinate y for the second point B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a coordinate z for the second point B: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double result = Distance3D(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Distance from point A to B = {result}");