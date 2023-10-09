// Задайте массив заполненный случайными положительными числами.
// Напишите программу, которая покажет количество четных чисел в массиве
 
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
int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int minValue = 100;
int maxValue = 1000;

int[] myArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(myArray);
Console.Write($" -> {EvenNumbers(myArray)}");

