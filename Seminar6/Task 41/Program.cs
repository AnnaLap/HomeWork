/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

//Method reading array from console and counting quantity of numbers > 0
void CountPositiveNum (int[] array, int size)
{
    Console.WriteLine("Enter numbers: ");
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.Write("{0}", string.Join(", ", array));
    Console.Write($" -> {count} (quantity of numbers > 0)");
}

Console.Write("Enter the quantity of numbers you wanna add: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[M];
CountPositiveNum(arr, M);
