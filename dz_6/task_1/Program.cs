// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int GetArraySize () 
{
    Console.Write($"Введите размер массива (целое положительное число): ");
    int size;

    while (!int.TryParse(Console.ReadLine(), out size) || (size < 0))
    {
        Console.WriteLine($"Ошибка ввода! Введите целое положительное число:");
    }

    return size;
}

int[] GetArray(int size)
{
    int[] array = new int[size];
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

int GetQuantityOfPositiveNumbers(int[] array)
{
    var quantity = 0;

    for (int i = 0; i < array.Length; i++ ) 
    {
        if (array[i] > 0) 
        {
            quantity++;
        }
    }

    return quantity;
}

var size = GetArraySize();
var array = GetArray(size);
var quantity = GetQuantityOfPositiveNumbers(array);
Console.Write($"Колличество положительных чисел, введенных пользователем равно: {quantity}");

