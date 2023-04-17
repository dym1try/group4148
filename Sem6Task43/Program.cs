// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых

Console.Clear();
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
// метод принимает 4 переменных и возвращает одну
double CalcX(int b1, int k1, int b2, int k2)
{
    //вычисляем координату X
    return (b2-b1)/(k1-k2);
}

// метод принимает 4 переменных и возвращает одну
double CalcY(int b1, int k1, int b2, int k2)
{
    //вычисляем координату Y
    return (CalcX(b1,k1,b2,k2)*k1)+b1;
}

int b1 = ReadData("Введите значение b1: ");
int k1 = ReadData("Введите значение k1: ");
int b2 = ReadData("Введите значение b2: ");
int k2 = ReadData("Введите значение k2: ");

Console.WriteLine ("Прямые пересекаются в точке: " + CalcX(b1,k1,b2,k2) +" , " + CalcY(b1,k1,b2,k2));
