// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetRandomArray (int size, int startValue, int endValue) 
{
    var array = new int[size];
    var random = new Random();

    for (int i = 0; i < array.Length; i++ ) 
    {
        array[i] = random.Next (startValue, endValue);
    }

    return array;
}

int GetQuantityEvenNumbers (int[] array)
{
    var quantity = 0;

    for (int i = 0; i < array.Length; i++ ) 
    {
        if (array[i] % 2 == 0) 
        {
            quantity++;
        }
    }

    return quantity;

}

Console.Write($"Введите размер массива (целое положительное число): ");
int size;

while (!int.TryParse(Console.ReadLine(), out size) || (size < 0))
{
    Console.WriteLine($"Ошибка ввода! Введите целое положительное число:");
}

var array = GetRandomArray(size, 100, 1000);
var quantity = GetQuantityEvenNumbers(array);
Console.Write($"Колличество четных чисел в массиве [{string.Join(", ", array)}] равно: {quantity}");
