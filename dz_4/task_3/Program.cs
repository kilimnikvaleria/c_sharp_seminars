// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.

int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите целое число (элемент массива номер {i}): ");

        while (!int.TryParse(Console.ReadLine(), out array[i]))
        {
            Console.WriteLine($"Ошибка ввода! Введите целое число (элемент массива номер {i}):");
        }
    }

    return array;
}

void PrintArrayToConsole(int[] array)
{
    Console.Write(string.Join(", ", array));
}

int[] array = GetArray();
PrintArrayToConsole(array);
