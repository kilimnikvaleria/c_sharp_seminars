// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

double number;

Console.WriteLine("Введите трёхзначное число: ");
while (!double.TryParse(Console.ReadLine(), out number) || ((number < 100) && (number > -100)) || (number >= 1000) || (number <= -1000))
{
    Console.WriteLine("Ошибка ввода! Введите трёхзначное число");
}

void getSecondDigit (double num) {
    
    if (num < 0) {
        num =  -1 * num;
    }

    int result = ((int)num / 10)%10; 

    Console.WriteLine($"Вторая цифра числа равна: {result}");
}

getSecondDigit (number);

