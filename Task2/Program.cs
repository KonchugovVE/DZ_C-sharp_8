// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
            myArray[i, j] = randomNumbers(-10, 10);
        }
    }
    return myArray;
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

int RectangleCheck(int lines, int columns)
{
    if (lines == columns)
    {
        columns = randomNumbers(2, 10);
        RectangleCheck(lines, columns);
    }
    return columns;
}


int[] AmountsInLines(int[,] args)
{
    int[] myArray = new int[args.GetLength(0)];

    for (int i = 0; i < args.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < args.GetLength(1); j++)
        {
            summ += args[i, j];
        }
        myArray[i] = summ;
    }
    return myArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] < 0)
        {
            System.Console.Write($"{array[i]}\t");
        }
        else
        {
            System.Console.Write($" {array[i]}\t");
        }

    }
}

int SearchLowerNamber(int[] array)
{
    int min = array[0];
    int LineMinValue = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            LineMinValue = i;
        }
    }
    return LineMinValue;
}

int lines = randomNumbers(2, 10);

int num = randomNumbers(2, 10);

int columns = RectangleCheck(lines, num);

int[,] TwoDArray = arrayFilling(lines, columns);

int[] SumElementsInTheLines = AmountsInLines(TwoDArray);

Print2DArray(TwoDArray);

System.Console.WriteLine();

PrintArray(SumElementsInTheLines);

System.Console.WriteLine($"\n Строка с наименьшей суммой элементов под №{SearchLowerNamber(SumElementsInTheLines) + 1}");

