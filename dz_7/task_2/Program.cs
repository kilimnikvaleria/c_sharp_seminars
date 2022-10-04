// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int GetNumber (string numberName) 
{
    Console.Write($"{numberName} (целое положительное число): ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number) || (number < 0))
    {
        Console.WriteLine($"Ошибка ввода! {numberName} (целое положительное число):");
    }

    return number;
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

string GetElMeaning (int linePosition, int columnPosition , int[,] array) 
{
    if (linePosition > array.GetLength(0) || columnPosition > array.GetLength(1)) 
    {
        return "такого числа нет в массиве";
    } else
    {
        return "" + array[linePosition, columnPosition] + "";
    }
}

var linesQuantity = GetNumber ("Задайте количество строк двумерного массива");
var columnsQuantity = GetNumber ("Задайте количество столбцов двумерного массива");
int[,] twoDimArray = new int[linesQuantity, columnsQuantity];
FillArray(twoDimArray);
PrintArray(twoDimArray);

Console.WriteLine("Задайте позицию элемента в двумерном массиве и программа покажет значение данного элемента");
var linePosition = GetNumber ("Задайте позицию элемента в строке");
var columnPosition = GetNumber ("Задайте позицию элемента в столбце");
Console.WriteLine(GetElMeaning (linePosition, columnPosition , twoDimArray) );
