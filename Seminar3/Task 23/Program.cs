/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

//Method of finding table cubes of numbers from 1 to n
void CubeTable (int n)
{
     double res = 0;
    for (int i = 1; i <= n; i++)
    {
        res = Math.Pow(i,3);
        Console.WriteLine($"{res}");
    }
}
Console.Write("Enter number N: ");
int N = Convert.ToInt32(Console.ReadLine());
CubeTable(N);