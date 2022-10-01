// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите целое пятизначное число: ");
int number;
while (!int.TryParse(Console.ReadLine(), out number) || ((number < 10000) && (number > -10000)) || (number >= 100000) || (number <= -100000))
{
    Console.WriteLine("Ошибка ввода! Введите трёхзначное число");
}

string determinePalindrome (int number) {
    
    if (number < 0) {
        return "Число не является палиндромом";
    } 

    int reverse = 0;
    
    for (int i = 0; i < 2; i++) {
        reverse = reverse*10 + number%10;
        number = number/10;
    }

    number = number/10;

    if (reverse == number) {
        return "Число является палиндромом";
    } else {
        return "Число не является палиндромом";
    }

}

string result = determinePalindrome (number);
Console.WriteLine(result);


