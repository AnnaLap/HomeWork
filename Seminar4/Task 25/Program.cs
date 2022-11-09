/*Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит
 число A в натуральную степень B. Для решения задания использование цикла for является 
 обязательным условием. Не использовать встроенный метод возведения в степень.
 3, 5 -> 243 (3⁵) 
 2, 4 -> 16 */

//Method of exponentitation of a number
int RaiseToPower(int num1, int num2)
{
    int res = 1;
    for (int i = 0; i < num2; i++)
    {
        res = res*num1;
    } 
    return res;
}

Console.Write("Enter A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int result = RaiseToPower(numA,numB);
Console.Write($"{numA} to the power of {numB} is {result}");