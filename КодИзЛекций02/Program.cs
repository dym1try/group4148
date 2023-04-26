// Найти сумму чисел от 1 до n

int SumFor(int n) // итеративный
{
    int result = 0;
    for (int i=1; i<= n; i++) result += i;
    return result;
}

int SumRec(int n) // рекурсия
{
    if (n==0) return 0;
    else return n + SumRec(n - 1);
}

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int n = ReadData("Введите число n: ");

Console.WriteLine("Итератив: " + SumFor(n));
Console.WriteLine("Рекурсия: " + SumRec(n));
