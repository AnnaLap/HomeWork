/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

//To multiply two matrix
void MultiplyMatrix(int[,] arr1, int[,] arr2)
{
    if (arr1.GetLength(0) > arr1.GetLength(1))
    {
        int[,] arr3 = new int[arr1.GetLength(0), arr1.GetLength(0)];
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(0); j++)
            {
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    arr3[i, j] += arr1[i, k] * arr2[k, j];
                }
                double num = Convert.ToDouble(arr3[i, j]);
                string str = Convert.ToString(Math.Round(num, 2)).PadRight(3);
                Console.Write($"{str} ");
            }
            Console.WriteLine(" ");
        }
    }
    else
    {
        int[,] arr3 = new int[arr2.GetLength(1), arr2.GetLength(1)];
        for (int i = 0; i < arr2.GetLength(1); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                for (int k = 0; k < arr2.GetLength(0); k++)
                {
                    arr3[i, j] += arr1[i, k] * arr2[k, j];
                }
                double num = Convert.ToDouble(arr3[i, j]);
                string str = Convert.ToString(Math.Round(num, 2)).PadRight(3);
                Console.Write($"{str} ");
            }
            Console.WriteLine(" ");
        }
    }
}

Console.Write("Enter M1: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[m1, n1];
Console.Write("Enter M2: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int[,] array2 = new int[m2, n2];
if (m1 != n2 && m2 != n1)
{
    Console.WriteLine("Multiplication of matrix is impossible");
    return;
}

FillArray(array1);
Console.WriteLine("Array 1: ");
ShowArray(array1);
FillArray(array2);
Console.WriteLine("Array 2: ");
ShowArray(array2);
Console.WriteLine(" ");
Console.WriteLine("Result: ");
MultiplyMatrix(array1, array2);