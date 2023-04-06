// Задача №21
// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
// метод принимает 6 переменных и возвращает одну
double CalcLen3D(int x1, int y1, int x2, int y2, int z1, int z2)
{
    //     корень    возведение во 2 степ.   
    return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
}

int x1 = ReadData("Введите координату X точки А: ");
int y1 = ReadData("Введите координату Y точки А: ");
int z1 = ReadData("Введите координату Z точки A: ");

int x2 = ReadData("Введите координату X точки B: ");
int y2 = ReadData("Введите координату Y точки B: ");
int z2 = ReadData("Введите координату Z точки B: ");


Console.WriteLine ("Расстояние между точками A и B: " + CalcLen3D(x1,y1,x2,y2,z1,z2));
