// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите целое число: ");
int number;
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Ошибка ввода! Введите целое число");
}

int[] GetCubeNumers(int number)
{
    int[] cubeNumbers = new int[number];

    // Заполнение массива результата
    for (int i = 0; i < number; i++)
    {
        cubeNumbers[i] = Convert.ToInt32(Math. Pow((i+1), 3));
    }

    return cubeNumbers;
}

int[] result = GetCubeNumers(number);
Console.Write(string.Join(", ", result));
