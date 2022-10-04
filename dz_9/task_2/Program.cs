// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

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

int GetSumNumbers (int m, int n) 
{
    if (m == n) 
    {
        return m;
    }

    if(m > n) {
        int sum = n + GetSumNumbers(m, n + 1);
        return sum;
    } else 
    {
        int sum = n + GetSumNumbers(m, n - 1);
        return sum;
    }
}

var m = GetNumber ("Задайте значение M");
var n = GetNumber ("Задайте значение N");
Console.WriteLine($"Сумма элементов от {m} до {n} равна: {GetSumNumbers(m, n)}");