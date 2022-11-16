/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

//Method finding Intersection Point of two lines
void FindIntersectionPoint(double b1, double b2, double k1, double k2)
{
    double x = -(b2 - b1)/(k2 - k1);
    double y = k1*x + b1;
    Console.Write($"Coordinate point of intersection ({Math.Round(x,3)}; {Math.Round(y,3)})");
}

Console.Write("Enter b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
FindIntersectionPoint(b1, b2, k1, k2);