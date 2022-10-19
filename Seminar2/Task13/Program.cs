/* Задача 13: Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Write($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = number;
int count = 0; 
while (number > 0)
{
    number = number / 10;
    count++;
}
Console.WriteLine($"Количество цифрр в числе: {count}");
 
 if (count < 3)
 {
Console.WriteLine($"Число меньше трехзначного");
 }
 else
 {
 while (count - 3 > 0)
 {
    num = num / 10;
    count--;
 }
Console.WriteLine($"Третья цифра числа: {num % 10}");
 }