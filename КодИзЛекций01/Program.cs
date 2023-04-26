// Рекурсия
// Собрать строку с числами от a до b, a<=b

string NumbersFor(int a, int b)// Итеративный
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a<=b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int a = ReadData("Введите число a: ");
int b = ReadData("Введите число b: ");

Console.WriteLine("Итеративный: " + NumbersFor(a, b));
Console.WriteLine("Рекурсия: " + NumbersRec(a, b));