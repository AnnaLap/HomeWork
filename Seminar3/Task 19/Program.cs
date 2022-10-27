/* Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

//Method for finding palindrome
void Palindrome (int numer)
{
int ReverseNum = 0;
int num = numer; 
    if (Math.Abs(numer)>9999 && Math.Abs(numer)<100000)
    {
        for (int i = 0; i < 5; i++)
        {
            ReverseNum = ReverseNum * 10 + num % 10;
            num = num / 10;
        }
        if (ReverseNum == numer && numer > 0)
        {
            Console.Write($"True, number {numer} is a palindrome");
        }
        else 
            Console.Write($"False, number {numer} is NOT a palindrome");
    }
        else
    {
        Console.Write("Number is NOT a five-digit!");
    }
}

Console.Write("Enter a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number);
