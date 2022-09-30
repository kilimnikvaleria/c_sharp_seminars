// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int dayNumber;

Console.WriteLine("Введите целое число, обозначающее день недели: ");
while (!int.TryParse(Console.ReadLine(), out dayNumber) || !(dayNumber > 0 && dayNumber < 8))
{
    Console.WriteLine("Ошибка ввода! Введите число от 1 до 7");
}

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("да, это выходной день");
  } else {
    Console.WriteLine("нет, этот день не выходной");
  }
}

CheckingTheDayOfTheWeek(dayNumber);