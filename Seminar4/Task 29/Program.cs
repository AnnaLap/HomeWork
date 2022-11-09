/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
Заполнение массива производит пользователь.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.WriteLine("Enter 8 elements of array: ");
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
   array[i] = int.Parse(Console.ReadLine());
}
Console.Write("Array: ");
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    if (i != array.Length-1)
    {
        Console.Write(array[i]+", ");
    }
    else
    Console.Write(array[i]);
}
Console.Write("]");
