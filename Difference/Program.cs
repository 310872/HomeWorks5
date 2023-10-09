//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива
// Пример [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round (new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 2);
    }
    return array;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
Console.WriteLine();
}
double DifferenceMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i=1; i < array.Length; i++)
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
    Console.Write($"{max} - {min} = ");
    return Math.Round(max - min, 2);
}
Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(myArray);
Console.Write(DifferenceMaxMin(myArray));
