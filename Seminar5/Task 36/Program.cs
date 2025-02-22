﻿/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

//Method forming an array of random numbers
void FormArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,100);
    }
    Console.Write("Array: [{0}]", string.Join(", ", array));
    Console.WriteLine("");
}

//Method counting sum of numbers with NOT even index
void CountSum (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum += array[i];
        }
    }
    Console.WriteLine($"Sum of numbers with NOT even index is {sum}");
}

Console.Write("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FormArray(numbers);
CountSum(numbers);

