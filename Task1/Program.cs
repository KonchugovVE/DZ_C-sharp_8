// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая упорядочивает по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int randomNumbers(int min,int max)
{
    Random rnd = new Random();
    int num = rnd.Next(min, max);
    return num;
}


int[,] arrayFilling()
{
    int[,] myArray = new int[randomNumbers(2,10), randomNumbers(2,10)];

    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = randomNumbers(-10,10);
        }
    }
    return myArray;
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

int [,] ArrayArranging (int [,]array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
           for (int n = j+1; n < array.GetLength(1); n++)
           {
            if (array[i,j]<array[i,n])
            {
                int temp = array[i,j];
                array[i,j]=array[i,n];
                array[i,n]=temp;
            }
           } 
        }
    }
    return array;
}

int [,] myArray = arrayFilling();
PrintArray(myArray);
System.Console.WriteLine();


int [,] ArrangedArray = ArrayArranging(myArray);
PrintArray(ArrangedArray);
