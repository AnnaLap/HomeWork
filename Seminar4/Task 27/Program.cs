/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
Для решения задания использование цикла for является обязательным условием
452 -> 11
82 -> 10
9012 -> 12 */

//Method of summing digits in a number
int ToGetSum (int num)
{
    string StrNum = Math.Abs(num).ToString();
    int lenght = StrNum.Length;
    int sum = 0;
    for (int i = 0; i < lenght; i++)
    {
        sum = sum + num%10;
        num = num/10;
    }
    return sum;
}
 
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = ToGetSum(number);
Console.WriteLine($"The sum of digits in a number is {result}");

