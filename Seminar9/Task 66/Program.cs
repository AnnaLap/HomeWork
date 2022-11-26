/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

//To sum naturals numbers from M to N
int SumNaturalNumbers(int m, int n)
{
    if (n == m)
    {
        return n;
    }
    return n + SumNaturalNumbers(m, n - 1);
}


Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < m)
{
    int temp = n;
    n = m;
    m = temp;
}
int res = SumNaturalNumbers(m, n);
Console.Write("Summary of natural elements: ");
Console.Write(res);
