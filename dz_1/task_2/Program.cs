// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int number1, number2, number3;

Console.WriteLine("Введите 3 целых числа и программа выведет максимальное");

Console.WriteLine("Введите первое число: ");

while (!int.TryParse(Console.ReadLine(), out number1))
{
    Console.WriteLine("Ошибка ввода! Введите целое первое число");
}

Console.WriteLine("Введите второе число: ");

while (!int.TryParse(Console.ReadLine(), out number2))
{
    Console.WriteLine("Ошибка ввода! Введите целое второе число");
}

Console.WriteLine("Введите третье число: ");

while (!int.TryParse(Console.ReadLine(), out number3))
{
    Console.WriteLine("Ошибка ввода! Введите целое третье число");
}

int max = number1;

if (number2 > max) {
    max = number2;
}

if (number3 > max) {
    max = number3;
}

//Или можно сделать с помощью Math
//int max = Math.Max(number1, Math.Max(number2, number3));

Console.WriteLine($"Максимальное число: {max}");
