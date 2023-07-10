// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7

int randomNumbers(int min, int max)
{
    Random rnd = new Random();
    int num = rnd.Next(min, max);
    return num;
}

int[,] arrayFilling(int lines, int columns)
{
    int[,] myArray = new int[lines, columns];

    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = randomNumbers(0, 10);
        }
    }
    return myArray;
}

void PrintTwo2DArrays(int[,] array, int[,] args)
{
    int maxLength = array.GetLength(0);
    if (maxLength < args.GetLength(0))
    {
        maxLength = args.GetLength(0);
    }
    for (int i = 0; i < maxLength; i++)
    {
        if (i < array.GetLength(0))
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
            System.Console.Write("|\t");
        }
        else
        {
            string[] indent = new string[array.GetLength(1)];
            for (int index = 0; index < indent.Length; index++)
            {
                indent[index] = "\t";
            }
            for (int count = 0; count < indent.Length; count++)
            {
                System.Console.Write("  " + indent[count]);
            }
            System.Console.Write("|\t");
        }
        if (i < args.GetLength(0))
        {
            for (int j = 0; j < args.GetLength(1); j++)
            {
                if (args[i, j] < 0)
                {
                    System.Console.Write($"{args[i, j]}\t");
                }
                else
                {
                    System.Console.Write($" {args[i, j]}\t");
                }
            }
        }
        System.Console.WriteLine();

    }
}

void Print2DArray(int[,] array)
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

int[,] ProductOfMatrices(int[,] array, int[,] args)
{
    int[,] myArray = new int[array.GetLength(0), args.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < args.GetLength(1); j++)
        {
            int work = 0;
            for (int b = 0; b < array.GetLength(1); b++)
            {
                work += array[i, b] * args[b, j];
            }
            myArray[i, j] = work;
        }
    }
    return myArray;
}

int numRandom = randomNumbers(2, 4);

int firstLines = randomNumbers(2, 4);

int firstColumns = numRandom;

int seccondLines = numRandom;

int seccondColumns = randomNumbers(2, 4);

int[,] firstArray = arrayFilling(firstLines, firstColumns);

int[,] seccondArray = arrayFilling(seccondLines, seccondColumns);

int[,] workArray = ProductOfMatrices(firstArray, seccondArray);

Print2DArray(firstArray);

System.Console.WriteLine();

Print2DArray(seccondArray);

System.Console.WriteLine();

PrintTwo2DArrays(firstArray, seccondArray);

System.Console.WriteLine();

Print2DArray(workArray);