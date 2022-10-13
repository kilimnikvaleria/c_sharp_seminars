// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void GetSortLines(int[,] array) 
{
    int tmp = 0;
    int max = array[1,1];
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            { 
                if(array[i,k] > array[i,k+1]) 
                {
                    tmp = array[i,k+1];
                    array[i,k+1] = array[i,k];
                    array[i,k] = tmp;
                }
            }
        }
    }
}

var linesQuantity = GetArraySize ("Задайте количество строк двумерного массива");
var columnsQuantity = GetArraySize ("Задайте количество столбцов двумерного массива");
int[,] twoDimArray = new int[linesQuantity, columnsQuantity];
FillArray(twoDimArray);
PrintArray(twoDimArray);
Console.WriteLine();
GetSortLines(twoDimArray);
PrintArray(twoDimArray);
