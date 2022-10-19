/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int number = new Random().Next(1,8);
Console.WriteLine($"Цифра дня недели: {number}");
if (number > 5) 
{
    Console.WriteLine($"Да, это выходной");
}
else
Console.WriteLine($"Нет, это рабочий день");

//Вариант ввода цифры с консоли 
Console.Write($"Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (0 < num && num < 8)
{
    if (num > 5)
    {
        Console.WriteLine($"Да, это выходной");
    }
    else
    {
        Console.WriteLine($"Нет, это рабочий день");
    }
}
else 
{
    Console.WriteLine($"Число не попадает в диапазон дней недели");
}