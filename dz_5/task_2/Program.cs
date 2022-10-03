// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Для удобства проверки задан диапазон случайных чисел от -100 до 100 (но можно убрать вообще границы и будет любое целое цисло, для этого необходимо удалить startValue и endValue в функции и ее вызове)

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

int GetSumElInOddPositions (int[] array)
{
    var sum = 0;

    for (int i = 1; i < array.Length; i += 2 ) 
    {
        sum = sum + array[i];
    }

    return sum;

}

Console.Write($"Введите размер массива (целое положительное число): ");
int size;

while (!int.TryParse(Console.ReadLine(), out size) || (size < 0))
{
    Console.WriteLine($"Ошибка ввода! Введите целое положительное число:");
}

var array = GetRandomArray(size, -100, 100);
var sum = GetSumElInOddPositions(array);
Console.Write($"Сумма элементов, стоящих на нечётных позициях в массиве [{string.Join(", ", array)}] равна: {sum}");
