// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите целое число: ");
int number;
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Ошибка ввода! Введите целое число");
}

int[] GetCubeNumers(int number)
{
    int[] cubeNumers = new int[number];

    // Заполнение массива результата
    for (int i = 1; i <= number; i++)
    {
        cubeNumers[i - 1] = i * i * i;
    }

    return cubeNumers;
}

int[] result = GetCubeNumers(number);
for (int i = 0; i < result.Length; i++) {
    if (i < result.Length-1) {
        Console.Write($"{result[i]}, ");
    } else {
        Console.Write(result[i]);
    }
}
