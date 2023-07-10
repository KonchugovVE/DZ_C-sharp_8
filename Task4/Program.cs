// Задача 4: * Напишите программу, которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int randomNumbers(int min, int max)
{
    Random rnd = new Random();
    int num = rnd.Next(min, max);
    return num;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 0)
            {
                System.Console.Write($"{array[i, j]}\t");
            }
            else
            {
                System.Console.Write($" {array[i, j]}\t");
            }
        }
        System.Console.WriteLine();
    }
}

int[,] spiralFilling(int count, int countNum, int[,] args)
{
    for (int i = count; i < args.GetLength(1) - count; i++)
    {
        args[count, i] = countNum;
        countNum += 1;
    }
    for (int i = count + 1; i < args.GetLength(0)-count; i++)
    {
        args[i, args.GetLength(1) - count - 1] = countNum;
        countNum += 1;
    }
    for (int i = args.GetLength(1) - 2 - count; i >= count; i--)
    {
        args[args.GetLength(0) - count - 1, i] = countNum;
        countNum += 1;
    }
    for (int i = args.GetLength(1) - 2 - count; i > count; i--)
    {
        args[i, count] = countNum;
        countNum += 1;
    }
    count += 1;
    if (args.GetLength(0) % 2 == 0)
    {
        if (count != args.GetLength(0) / 2)
        {
            spiralFilling(count, countNum, args);
        }
    }
    if (args.GetLength(0) % 2 != 0)
    {
        if (count != args.GetLength(0) / 2 + 1)
        {
            spiralFilling(count, countNum, args);
        }
    }
    return args;
}

int count = 0;
int countNum = 1;
int numbers = randomNumbers(2,10);
int[,] myArray = new int[numbers, numbers];
int[,] filledArray = spiralFilling(count, countNum, myArray);
PrintArray(filledArray);