// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GetRandomArray (int size) 
{
    var array = new double[size];
    var random = new Random();

    for (int i = 0; i < array.Length; i++ ) 
    {
        array[i] = Math.Round(random.NextDouble (),2);
    }

    return array;
}

double GetDifferenceMaxMin (double[] array)
{
    var max = array[0];
    var min = array[0];

    for (int i = 1; i < array.Length; i++ ) 
    {
        if(array[i]>max) 
        {
            max = array[i];
        } else 
        {
            if (array[i] < min) 
            {
                min = array[i];
            }
        }
    }

    var difference = Math.Round((max - min),2);

    return difference;

}

Console.Write($"Введите размер массива (целое положительное число): ");
int size;

while (!int.TryParse(Console.ReadLine(), out size) || (size < 0))
{
    Console.WriteLine($"Ошибка ввода! Введите целое положительное число:");
}

var array = GetRandomArray(size);
var difference = GetDifferenceMaxMin(array);
Console.Write($"Разницу между максимальным и минимальным элементов в массиве [{string.Join("; ", array)}] равна: {difference} ");