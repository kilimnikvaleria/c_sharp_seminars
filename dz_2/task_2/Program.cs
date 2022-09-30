// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

double number;

Console.WriteLine("Введите число: ");
while (!double.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Ошибка ввода! Введите число");
}

void getThirdDigit (double num) {
    
    if (num < 0) {
        num =  -1 * num;
    }

    int numberInt = (int)num;

    while (numberInt > 999) {
        numberInt = numberInt / 10;
    }

    if (numberInt < 100) {
        Console.WriteLine("Третьей цифры нет");
    } else {
        int result = numberInt % 10; 
        Console.WriteLine($"Третья цифра числа равна: {result}");
    }
}

getThirdDigit (number);
