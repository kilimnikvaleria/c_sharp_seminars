// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double GetСoefficient(string coefficientName)
{
    Console.Write($"Введите коэффициент {coefficientName}: ");
    
    double coefficient;

    while (!double.TryParse(Console.ReadLine(), out coefficient))
    {
        Console.WriteLine($"Ошибка ввода! Введите коэффициент {coefficientName}:");
    }

    return coefficient;
}

string GetPointOfIntersection(double b1, double k1, double b2, double k2) 
{
    if (b1==b2 & k1==k2) 
    {
        return"Прямые совпадают";
    }
    
    if (k1==k2) 
    {
        return"Прямые параллельны друг другу";
    } 

    var xIntersection = (b2-b1)/(k1-k2);
    var yIntersection = k1*xIntersection + b1;

    return "Точка пересечения"+" ("+ Math.Round(xIntersection, 2)+" ;"+Math.Round(yIntersection, 2)+ ")";
}

double b1 = GetСoefficient("b1");
double k1 = GetСoefficient("k1");
double b2 = GetСoefficient("b2");
double k2 = GetСoefficient("k2");

Console.Write(GetPointOfIntersection(b1, k1, b2, k2));
