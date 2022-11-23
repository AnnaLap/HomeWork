/* Задача 52. Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для поиска ср. арифметического значения каждого столбца.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

//To fill array with random int numbers from 1 to 9
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
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
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine(" ");
    }
}

//To show average of each columns of array
void ShowAverageColumns(int[,] arr)
{
    Console.Write("Average of columns: ");
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        double res = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j,i];
        }
        res = sum / arr.GetLength(0);
        Console.Write($"{Math.Round(res, 2)}; ");
    }
}

Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
ShowArray(array);
ShowAverageColumns(array);