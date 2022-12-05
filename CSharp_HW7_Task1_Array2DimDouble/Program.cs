// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0.

// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

Console.Clear();

double[,] Fill2DimArray(int rows, int columns)
{
    double[,] arrayTwoDim = new double[rows, columns];
    for (int i = 0; i < arrayTwoDim.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwoDim.GetLength(1); j++)
        {
            arrayTwoDim[i, j] = Math.Round((new Random().Next(-10, 11) + new Random().NextDouble()), 2);
        }
    }
    return arrayTwoDim;
}

void Print2DimArray(double[,] arrayTwoDimForPrint)
{
   for (int i = 0; i < arrayTwoDimForPrint.GetLength(0); i++)
   {
        for (int j = 0; j < arrayTwoDimForPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayTwoDimForPrint[i, j]}   ");
        }
        Console.WriteLine(); 
   } 
}

Console.Write("Введите количество строк в массиве: ");
int rowsArray = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columnsArray = int.Parse(Console.ReadLine());

double[,] array = Fill2DimArray(rowsArray, columnsArray);
Print2DimArray(array);