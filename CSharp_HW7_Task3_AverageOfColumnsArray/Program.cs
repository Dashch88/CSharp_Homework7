// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] Fill2DimArray(int rows, int columns)
{
    int[,] arrayTwoDim = new int[rows, columns];
    for (int i = 0; i < arrayTwoDim.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwoDim.GetLength(1); j++)
        {
            arrayTwoDim[i, j] = new Random().Next(0, 10);
        }
    }
    return arrayTwoDim;
}

void Print2DimArray(int[,] arrayTwoDimForPrint)
{
    for (int i = 0; i < arrayTwoDimForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwoDimForPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayTwoDimForPrint[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] AverageColumnsInArray(int[,] arrayTwoDimAverageColumns)
{
    double[] arrayAverageColumns = new double[arrayTwoDimAverageColumns.GetLength(1)];
    for (int j = 0; j < arrayTwoDimAverageColumns.GetLength(1); j++)
    {
        for (int i = 0; i < arrayTwoDimAverageColumns.GetLength(0); i++)
        {
            arrayAverageColumns[j] += arrayTwoDimAverageColumns[i, j];
        }
        arrayAverageColumns[j] = Math.Round((arrayAverageColumns[j] / arrayTwoDimAverageColumns.GetLength(0)), 2);
    }
    return arrayAverageColumns;
}

void PrintArray(double[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        Console.Write($"{arrayForPrint[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк в массиве: ");
int rowsArray = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columnsArray = int.Parse(Console.ReadLine());

int[,] array = Fill2DimArray(rowsArray, columnsArray);
Print2DimArray(array);
double[] arrayAvrgColmns = AverageColumnsInArray(array);
Console.Write("Средние арифметические каждого столбца: ");
PrintArray(arrayAvrgColmns);