// Задача 1:
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GenerateArray (int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }

    return result;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int NumberOfEven (int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count++;
        }
    }

    return count;
}

int arrSize = 20;
int arrMinValue = 100;
int arrMaxValue = 999;

int[] myArray = GenerateArray(arrSize, arrMinValue, arrMaxValue);
printArray(myArray);
System.Console.WriteLine($"Количество четных элементов в массиве равно {NumberOfEven(myArray)}");
