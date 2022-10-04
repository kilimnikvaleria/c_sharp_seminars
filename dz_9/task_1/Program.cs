// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int GetNumber (string numberName) 
{
    Console.Write($"{numberName} (целое положительное число): ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number) || (number <= 0))
    {
        Console.WriteLine($"Ошибка ввода! {numberName} (целое положительное число):");
    }

    return number;
}

string ShowNumbers (int n) 
{
    if (n == 1) 
    {
        return "1";
    }

    return n + " " + ShowNumbers(n - 1);
}

var n = GetNumber ("Задайте значение N");
Console.WriteLine($"Числа от {n} до 1: {ShowNumbers(n)}");
