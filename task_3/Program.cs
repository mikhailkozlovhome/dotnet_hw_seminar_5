// Задача 3:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double[] GenerateArray (int length, int minValue, int maxValue)
{
    double[] result = new double[length];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Convert.ToDouble(rnd.Next(minValue, maxValue + 1))/7;
    }

    return result;
}

void printArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:f2} | ");
    }
    System.Console.WriteLine();
}

double MaxMinDifference (double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        };

        if (array[i] < min)
        {
            min = array[i];
        }
    }

    return max - min;
}

int arrSize = 10;
int arrMinValue = 0;
int arrMaxValue = 100;

double[] myArray = GenerateArray(arrSize, arrMinValue, arrMaxValue);
printArray(myArray);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {MaxMinDifference(myArray):f2}");
