﻿/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

//To fill array spirally
void FillSpiralArray(int[,] arr, int size)
{
    int i = 0;
    int j = 0;
    int count = 1;
    while (count <= size * size)
    {
        arr[i, j] = count;
        if (i <= j + 1 && i + j < size - 1) { ++j; }
        else if (i < j && i + j >= size - 1) { ++i; }
        else if (i >= j && i + j > size - 1) { --j; }
        else { --i; }
        ++count;
    }
}

//To print spiral array
void PrintSpiralArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int length = 4;
int[,] array = new int[length, length];
Console.WriteLine("Spiral array: ");
FillSpiralArray(array, length);
PrintSpiralArray(array);


