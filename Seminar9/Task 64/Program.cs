/* Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

//To show naturals numbers from N to 1
int NaturalNumbers(int n)
{
    if (n == 1)
    { return 1; }
    Console.Write(n + ", ");
    return NaturalNumbers(n - 1);
}

Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = NaturalNumbers(n);
Console.WriteLine(res);