// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

void FillArray(int[,] array)
{ 
    int i = 0;
    int j = 0;
    int row = 0;
    int column = 0;

    for(int k = 1; k <= array.GetLength(0)*array.GetLength(1); k++) {
        array[i, j] = k;
        // если есть возможность двигаться слева направо
        if (i == row && j < array.GetLength(1) - row - 1)
            ++j;
        // иначе если есть возможность двигаться сверху вниз
        else if (j == array.GetLength(1) - column - 1 && i < array.GetLength(0) - row - 1)
            ++i;
        // иначе если есть возможность двигаться справа налево
        else if (i == array.GetLength(0) - row - 1 && j > column)
            --j;
        // иначе двигаться снизу вверх
        else
            --i;
        // когда находимся в конце круга, то обновляем счетчики строк и колонок
        // последнее условие в случае если матрица состоит из одной колонки
        if((i == row + 1) && (j == column) && (row != array.GetLength(1) - row - 1)) {
            row++;
            column++;
        }
    }
}

void PrintArray(int[,] array)
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        { 
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

// Объявляем и инициализируем массив.
int[,] array = new int[4, 4];

//Заполняем массив
FillArray(array);

// Выводим массив
PrintArray(array);