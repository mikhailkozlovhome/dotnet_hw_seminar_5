// Задача 2:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int SumElements (int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }

    return sum;
}

int arrSize = 10;
int arrMinValue = -10;
int arrMaxValue = 10;

int[] myArray = GenerateArray(arrSize, arrMinValue, arrMaxValue);
printArray(myArray);
System.Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна {SumElements(myArray)}");
