// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetMinSumLine(int[,] array) 
{
    int[] sum = new int[array.GetLength(0)];
    int min = 0;
    int min_i = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            sum[i] = sum[i] + array[i, j];
        }

        if (sum[i] < min) 
        {
            min = sum[i];
            min_i = i + 1;
        }
    }

    return min_i;
}

var linesQuantity = GetArraySize ("Задайте количество строк двумерного массива");
var columnsQuantity = GetArraySize ("Задайте количество столбцов двумерного массива");
int[,] twoDimArray = new int[linesQuantity, columnsQuantity];
FillArray(twoDimArray);
PrintArray(twoDimArray);
var minLine = GetMinSumLine(twoDimArray);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minLine}");

