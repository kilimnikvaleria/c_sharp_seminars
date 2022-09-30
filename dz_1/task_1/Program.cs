// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int number1, number2;

Console.WriteLine("Введите 2 целых числа и программа скажет какое из них больше");

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

if(number1 > number2)
{
    Console.WriteLine("Первое число больше второго");
}
else if (number1 < number2)
{
    Console.WriteLine("Первое число меньше второго");
}
else
{
    Console.WriteLine("Оба числа равны");
}