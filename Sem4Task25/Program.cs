// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// 3, 5 -> 243 (3⁵)  // 2, 4 -> 16

Console.Clear();

// Чтение данных с консоли
int ReadData(string message) //
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод вывода результата
void PrintResult(string msg, long res)
{
    Console.WriteLine(msg + res);
}


long MyPowSimple(int a, int b)
{
    long res = 1;
    while (b > 0)
    {
        res = res * a;
        b = b - 1;
    }
    return res;
}

long MyPowFormula(int a, int b)
{
    long resf = 1;
    resf = (long)Math.Pow(a, b);
    return resf;
}

int a = ReadData("Введите число a: ");
int b = ReadData("Введите число b: ");
long res = MyPowSimple(a, b);
long resf = MyPowFormula(a, b);
PrintResult("Число a в степени b (простой метод): ", res);
PrintResult("Число a в степени b (метод с формулой): ", resf);