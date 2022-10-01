// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int GetCoordinate(string coordinateName, string pointName)
{
    Console.Write($"Введите координату {coordinateName} точки {pointName}: ");
    
    int coordinate;
    while (!int.TryParse(Console.ReadLine(), out coordinate))
    {
        Console.WriteLine($"Ошибка ввода! Введите координату {coordinateName} точки {pointName}:");
    }

    return coordinate;
}

int x1 = GetCoordinate("x", "A");
int y1 = GetCoordinate("y", "A");
int z1 = GetCoordinate("z", "A");
int x2 = GetCoordinate("x", "B");
int y2 = GetCoordinate("y", "B");
int z2 = GetCoordinate("z", "B");

double GetDistanceTwoPoint(int x1, int y1, int z1, int x2, int y2, int z2) 
{
    double distanse = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

    return distanse;
}

double result = GetDistanceTwoPoint(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {Math.Round(result, 2, MidpointRounding.ToNegativeInfinity)}");
