/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

//Method forming an array of random numbers
void FormArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
    }
    Console.Write("Array: [{0}]", string.Join(", ", array));
    Console.WriteLine("");
}

//Method finding difference between max and min numbers
void DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double diff = max - min;
    Console.WriteLine($"Difference between max and min numbers is {diff}");
}

Console.Write("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FormArray(numbers);
DiffMaxMin(numbers);
