// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Решить задачу с использованием методов.

int GetNumber(string numberName)
{
    Console.Write($"Введите целое число {numberName}: ");
    
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine($"Ошибка ввода! Введите целое число {numberName}:");
    }

    return number;
}

int GetExponentiation (int numberA, int numberB) 
{
    int result = numberA;

    for(int i = 1; i < numberB; i++){
        result = result * numberA;
    }

    return result;
}

int numberA = GetNumber("A");
int numberB = GetNumber("B");
int exponentiation = GetExponentiation(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} равно: {exponentiation}");