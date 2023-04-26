// Факториал числа
int FactorialFor(int n)// итеративный
{
    int result = 1;
    for (int i = 1; i<= n; i++) result *=i;
    return result;
}

int FactorialRec(int n)// рекурсивный
{
    if (n==1) return 1;
    else return n * FactorialRec(n-1);
}

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int n = ReadData("Введите число n: ");

Console.WriteLine("Итератив: " + FactorialFor(n));
Console.WriteLine("Рекурсия: " + FactorialRec(n));