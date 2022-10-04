// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int GetArraySize (string sizeName) 
{
    Console.Write($"{sizeName} (целое положительное число): ");
    int size;

    while (!int.TryParse(Console.ReadLine(), out size) || (size < 0))
    {
        Console.WriteLine($"Ошибка ввода! {sizeName} (целое положительное число):");
    }

    return size;
}

void FillArray(int[,] array)
{ 
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        { 
            array[i,j] = random.Next(-100, 100);
        }
    }
}

void PrintArray(int[,] array)
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        { 
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

double[] GetSumAverageColumn (int[,] array) 
{
    int sum = 0;
    double[] average = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    { 
        for (int j = 0; j < array.GetLength(0); j++)
        { 
            sum = sum + array[j, i];
        }

        average[i] = Math.Round(((double)sum/array.GetLength(0)), 2);
        sum = 0;
    }

    return average;
}

var linesQuantity = GetArraySize ("Задайте количество строк двумерного массива");
var columnsQuantity = GetArraySize ("Задайте количество столбцов двумерного массива");
int[,] twoDimArray = new int[linesQuantity, columnsQuantity];
FillArray(twoDimArray);
PrintArray(twoDimArray);
var sumAverageColumn = GetSumAverageColumn (twoDimArray);
Console.Write($"Cреднее арифметическое элементов в каждом столбце: [{string.Join("; ", sumAverageColumn)}]");