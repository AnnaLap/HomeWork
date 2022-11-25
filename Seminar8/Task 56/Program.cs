/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


//To fill array with random int numbers from 1 to 9
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

//To show filling array
void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine(" ");
    }
}

//To count summary of elements for each row in array and return index of row with max sum
int MaxSumRow(int[,] arr)
{
    int[] sum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum[i] += arr[i, j];
        }
    }
    int maxRow = 0;
    for (int i = 0; i < sum.GetLength(0); i++)
        if (sum[i] > sum[maxRow])
        {
            maxRow = i;
        }
    return maxRow;
}

Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
Console.WriteLine("Array: ");
ShowArray(array);
int res = MaxSumRow(array);
Console.WriteLine($"Row with max summary of elements is {res}");

