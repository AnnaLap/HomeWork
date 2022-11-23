/* Задача 50. Напишите программу, которая будет принимать от пользователя 
позицию (M, N) двумерного массива и возвращать значение элемента, стоящего
в этой позиции. Если такой позиции в массиве нет, то сообщить об этом пользователю. 
Cгенерировать массив случайным образом. Размерность массива определить самостоятельно. 
Использование методов для заполнения массива обязательно. Остальное можно реализовать 
в главной программе.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
M = 1, N = 7 -> В массиве отсутствует элемент в такой позиции.*/

//Прога написана с учетом, что индексы принятые пользователем считаются в матрице от 0. 

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

//To show element of array with index [m,n] if it exists
void ShowElementOfArray(int[,] arr, int rows, int columns)
{
    if (rows >= arr.GetLength(0) || columns >= arr.GetLength(1))
    {
       Console.WriteLine($"Element with position ({rows}, {columns}) doesn't exist"); 
    }
    else
    {
        Console.WriteLine($"Element with position ({rows}, {columns}) is {arr[rows, columns]}"); 
    }
}

Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[5,5];
FillArray(array);
ShowArray(array);
ShowElementOfArray(array, m, n);
