/* Задача 47. Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). 
Округлите значения, генерируемые Random до двух знаков после запятой.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

//To fill array with random double numbers
void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().NextDouble()*10;
        }
    }
}

//To show filling array in the beaty way 
void ShowArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            double num = Convert.ToDouble(arr[i,j]);
            string str = Convert.ToString(Math.Round(num, 2)).PadRight(4); //for beauty :)
            Console.Write($"{str} ");
        }
        Console.WriteLine(" ");
    }
}

Console.Write("Enter quantity of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantity of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];
FillArray(array);
ShowArray(array);