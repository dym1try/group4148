// Задача 67. Посчитать сумму всех в числе.


//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Рекур.метод
int SumDigRec(int m)
{
    if(m>0)
    {
        return m%10+SumDigRec(m/10);
    }
    else
    {
        return m;
    }
}

int M = ReadData("Введите число: ");
int Sum = SumDigRec(M);
Console.Write(Sum);
