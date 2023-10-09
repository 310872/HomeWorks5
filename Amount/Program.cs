// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечетных позициях

using System.Runtime.InteropServices;

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
        int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write( array[i] + " " );
    }
}
int AmountNumbersOddPosition(int[] array)
{
    int sum = 0;
    for (int i=1; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(myArray);
Console.Write($" -> {AmountNumbersOddPosition(myArray)}");


