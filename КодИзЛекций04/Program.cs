// Возвести число a в степень n.

int PowerFor(int a, int n)//Итератив
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)//Рекурсия
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)//Рекурсия продвинутая
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRec(a, n - 1) * a;
}

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
int a = ReadData("Введите число a: ");
int n = ReadData("Введите число n: ");

DateTime d1 = DateTime.Now;
Console.WriteLine("Итератив: " + PowerFor(a, n));
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
Console.WriteLine("Рекурсия: " + PowerRec(a, n));
Console.WriteLine(DateTime.Now - d2);

DateTime d3 = DateTime.Now;
Console.WriteLine("Рекурсия продвинутая: " + PowerRecMath(a, n));
Console.WriteLine(DateTime.Now - d3);