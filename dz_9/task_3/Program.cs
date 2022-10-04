// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int GetNumber (string numberName) 
{
    Console.Write($"{numberName} (целое положительное число): ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number) || (number < 0))
    {
        Console.WriteLine($"Ошибка ввода! {numberName} (целое положительное число):");
    }

    return number;
}

int GetResultAckermannFunction (int m, int n) 
{
    if (m == 0) 
    {
        return n + 1;
    } 
    if (n == 0 && m > 0) 
    {
        return GetResultAckermannFunction(m - 1, 1);
    } else 
    {
        return GetResultAckermannFunction(m - 1, GetResultAckermannFunction(m, n - 1));
    }
}

var m = GetNumber ("Задайте значение M");
var n = GetNumber ("Задайте значение N");
Console.WriteLine($"A(m,n) = {GetResultAckermannFunction(m, n)}");
