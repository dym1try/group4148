// Задача №20
// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
// метод принимает 4 переменных и возвращает одну
double CalcLen2D(int x1, int y1, int x2, int y2)
{
    //     корень    возведение во 2 степ.   то же самое по простому
    return Math.Sqrt(Math.Pow((x1 - x2), 2) + (y1-y2) * (y1-y2));
}

int x1 = ReadData("Введите координату X точки А: ");
int y1 = ReadData("Введите координату Y точки А: ");
int x2 = ReadData("Введите координату X точки B: ");
int y2 = ReadData("Введите координату Y точки B: ");

Console.WriteLine ("Расстояние между точками A и B: " + CalcLen2D(x1,y1,x2,y2));