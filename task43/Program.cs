/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Введите координаты b1, k1, b2, k2:");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

void FindCrossing (double b1, double k1, double b2, double k2)
{
    double firstPoint = (b2 - b1)/(k1 - k2);
    double secondPoint = k1 * firstPoint + b1;
    Console.WriteLine($"Точка пересечений ({firstPoint}; {secondPoint})");
}

FindCrossing(b1, k1, b2, k2);