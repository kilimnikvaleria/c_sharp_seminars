// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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

int[] GetProductOfPairsOfNumbers (int[] array)
{
    var productArray = new int[(int)Math.Ceiling((double)array.Length/2)];

    for (int i = 0; i < productArray.Length; i++) 
    {
        if(i != (array.Length-1-i))
        {
            productArray[i] = array[i]*array[array.Length-1-i];
        } else 
        {
            productArray[i] = array[i];
        }
    }

    return productArray;

}

Console.Write($"Введите размер массива (целое положительное число): ");
int size;

while (!int.TryParse(Console.ReadLine(), out size) || (size < 0))
{
    Console.WriteLine($"Ошибка ввода! Введите целое положительное число:");
}

var array = GetRandomArray(size, -100, 100);
var productArray = GetProductOfPairsOfNumbers(array);
Console.Write($"Произведение пар чисел в одномерном массиве [{string.Join(", ", array)}] равно: [{string.Join(", ", productArray)}]");