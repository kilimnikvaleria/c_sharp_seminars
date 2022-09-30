// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number;

Console.WriteLine("Введите целое число: ");
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Ошибка ввода! Введите целое число");
}

void getThirdDigit (int num) {
    
    if (num < 0) {
        num *=  -1;
    }

    if (num < 100) {
        Console.WriteLine("Третьей цифры нет");
    } else {
        while (num > 999) {
            num = num / 10;
        }
        int result = num % 10; 
        Console.WriteLine($"Третья цифра числа равна: {result}");
    }
}

getThirdDigit (number);
