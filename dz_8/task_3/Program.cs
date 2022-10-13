// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

void PrintArray(int[,] array, string text)
{ 
    Console.WriteLine($"{text}");

    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        { 
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrixMultiplication (int[,] matrixA, int[,] matrixB) 
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
      for (int i = 0; i < matrixA.GetLength(0); i++)
      {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
          for (int k = 0; k < matrixA.GetLength(1); k++)
          {
            matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
          }
        }
      }
      return matrixC;
}

var rowsA = GetArraySize ("Введите количество строк 1 матрицы");
var columnsA = GetArraySize ("Введите количество столбцов 1 матрицы");
var rowsB = GetArraySize ("Введите количество строк 2 матрицы");
var columnsB = GetArraySize ("Введите количество столбцов 2 матрицы");
if (columnsA != rowsB)
{
    Console.WriteLine("Такие матрицы умножать нельзя!");
} else {
    int[,] matrixA = new int[rowsA, columnsA];
    FillArray(matrixA);
    PrintArray(matrixA, "Матрица 1:");
    int[,] matrixB = new int[rowsB, columnsB];
    FillArray(matrixB);
    PrintArray(matrixB, "Матрица 2:");
    int[,] matrixC = GetMatrixMultiplication(matrixA, matrixB);
    PrintArray(matrixC, "Произведение матриц:");
}
