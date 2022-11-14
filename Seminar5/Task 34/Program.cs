/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

//Method forming an array of three-digits numbers
void FormArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    Console.Write("Array: [{0}]", string.Join(", ", array));
    Console.WriteLine("");
}


//Method counting quantity of even numbers in array
void CountEvenNum (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Quantity of even numbers is {count}");
}

Console.Write("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FormArray(numbers);
CountEvenNum(numbers);



