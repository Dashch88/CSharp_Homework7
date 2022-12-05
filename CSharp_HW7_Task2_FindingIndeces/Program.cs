// Задача 50. Напишите программу, которая на вход принимает число, 
// и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void FindingNumInArray(int[,] arrayForSearch, int searchNum)
{
    bool checkIndex = false;
    for (int i = 0; i < arrayForSearch.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForSearch.GetLength(1); j++)
        {
            if (arrayForSearch[i, j] == searchNum)
            {
                Console.WriteLine($"Индексы искомого числа {searchNum} = [{i}, {j}]");
                checkIndex = true;
            }
        }
    }
    if (checkIndex == false)
    {
        Console.WriteLine("Такого числа нет в массиве.");
    }
}

Console.Write("Введите количество строк в массиве: ");
int rowsArray = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columnsArray = int.Parse(Console.ReadLine());

int[,] array = Fill2DimArray(rowsArray, columnsArray);
Print2DimArray(array);

Console.Write("Введите искомое число в массиве: ");
int desiredNum = int.Parse(Console.ReadLine());

FindingNumInArray(array, desiredNum);