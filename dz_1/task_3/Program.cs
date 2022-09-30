//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int number1;

Console.WriteLine("Введите целое число и программа определит, является ли число чётным");

while (!int.TryParse(Console.ReadLine(), out number1))
{
    Console.WriteLine("Ошибка ввода! Введите целое число");
}

if (number1 % 2 == 0) {
    Console.WriteLine("Четное");
}
else {
    Console.WriteLine("Нечетное");
}