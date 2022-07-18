/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


void IntersectionLinesPoint(double k1, double b1, double k2, double b2)
{
    if ((k1 - k2) == 0) Console.WriteLine("b1 = {0}, k1 = {1}, b2 = {2}, k2 = {3} -> (линии уравнений паралельны)", b1, k1, b2, k2);
    else
    {
        double x = 0;
        x = (b2 - b1) / (k1 - k2);
        double y = 0;
        y = k1 * x + b1;
        Console.WriteLine("b1 = {0}, k1 = {1}, b2 = {2}, k2 = {3} -> ({4:f1} ; {5:f1})", b1, k1, b2, k2, x, y);
    }
}

Console.Clear();
Console.WriteLine("Две прямые заданы уравнениями");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");
Console.Write("Введите значение для переменной k1 : ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение для переменной b1 : ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение для переменной k2 : ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение для переменной b2 : ");
double b2 = Convert.ToDouble(Console.ReadLine());
IntersectionLinesPoint(k1, b1, k2, b2);