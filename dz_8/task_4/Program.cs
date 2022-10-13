// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

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

bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el) return true;
            }
        }
    }
    return false;
}

void FillArray(int[,,] array)
{ 
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int element = random.Next(-100, 100);
                if (FindElement(array, element)) continue;
                array[i, j, k] = element;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите размерность трехмерного массива:");
var dimension1 = GetArraySize ("Введите размерность 1");
var dimension2= GetArraySize ("Введите размерность 2");
var dimension3 = GetArraySize ("Введите размерность 3");
int[,,] threeDimArray = new int[dimension1, dimension2, dimension3];
FillArray(threeDimArray);
PrintArray(threeDimArray);
