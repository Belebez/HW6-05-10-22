// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//  y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x = b2 - b1 / (k1 - k2)
// y = (k1 * x) + b1;

Console.WriteLine("Программа ищёт пересечение двух прям, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine();

var coord = InterPoint();
Console.WriteLine();
Console.WriteLine($"Координаты пересечения двух прямых --> ({coord.Item1}, {coord.Item2})");

(double, double) InterPoint()  // ввод значений пользователем и поиск точки координат.
{
    Console.Write("Введите любое значение для параметра k1 - ");
    double k1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите любое значение для параметра b1 - ");
    double b1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите любое значение для параметра k2 - ");
    double k2 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите любое значение для параметра b2 - ");
    double b2 = double.Parse(Console.ReadLine()!);
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * x) + b1;

    return (x, y);
}