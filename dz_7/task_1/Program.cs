// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
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

void FillArray(double[,] array)
{ 
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        { 
            array[i,j] = Convert.ToDouble(random.Next(-100, 100)/10.0);
        }
    }
}

void PrintArray(double[,] array)
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

var linesQuantity = GetArraySize ("Задайте количество строк двумерного массива");
var columnsQuantity = GetArraySize ("Задайте количество столбцов двумерного массива");
double[,] twoDimArray = new double[linesQuantity, columnsQuantity];
FillArray(twoDimArray);
PrintArray(twoDimArray);


