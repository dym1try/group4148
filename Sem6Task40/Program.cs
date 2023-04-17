// Задача №40  Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

Console.Clear();

// Чтение данных с консоли
int ReadData(string message) //
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

bool TrianTest(int a, int b, int c)
{
    if ((a < b + c) && (b < a + c) && (c < a + b))// или проще одной строкой return ((a+b>c)&& (a+c>b)&& (b+c>a));
    {
        return true;
    }
    return false;
}

int a = ReadData("Введите сторону a: ");
int b = ReadData("Введите сторону b: ");
int c = ReadData("Введите сторону c: ");

TrianTest(a, b, c);

if (TrianTest(a, b, c))
{
    Console.WriteLine("Такой треугольник существует.");
}
else
{
    Console.WriteLine("Такого треугольника не существует.");
}