// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSumDigit(int number)
{
    // Количество цифр в числе
    int sum = 0;

    // Временная переменная для хранения входного значения
    int tempNumber = Math.Abs(number);

    // Подсчет суммы цифр в числе
    while (tempNumber != 0)
    {
        // Подсчет суммы
        sum = sum + tempNumber % 10;

        // Избавление от правой крайней цифры
        tempNumber = tempNumber / 10;

    }

    // Возврат результата
    return sum;
}

int GetNumber()
{
    Console.Write($"Введите целое число: ");
    
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine($"Ошибка ввода! Введите целое число:");
    }

    return number;
}

int number = GetNumber();
int sumDigit = GetSumDigit(number);
Console.WriteLine($"Сумма цифр в числе {number}: {sumDigit}");
