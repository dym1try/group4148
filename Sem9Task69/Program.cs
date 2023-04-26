// Задача 69. Возведите число A в степень B.

// //Ввод данных
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// //Рекур.метод
// long PowRec(int a, int b)
// {
//     if (b > 0)
//     {
//         return a * PowRec(a, b - 1);
//     }
//     else
//     {
//         return 1;
//     }

// }

// int A = ReadData("Введите число: ");
// int B = ReadData("Введите степень числа: ");
// long PowAB = PowRec(A,B);
// Console.Write(PowAB);

//Console.Clear();

//Метод ввода 
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

long AxB(int n,int m)
{     

    if (m > 0)
    {   
        return n*AxB(n,m-1);
    }
    else
    {
        return 1;
    }
}

long MyAxB(int n,int m)
{     

    if (m == 2)
    {   
        return 4;
    }
    else
    {
        return AxB(n,m/2)*AxB(n,m/2);
    }
}

int n = ReadData("Введите число N: ");
int m = ReadData("Введите число M: ");

// DateTime d1 = DateTime.Now;
// AxB(n,m);
// Console.WriteLine("Решение AxB" + (DateTime.Now - d1));

DateTime d2 = DateTime.Now;
MyAxB(n,m);
Console.WriteLine("Решение MyAxB" + (DateTime.Now - d2));
//long sum = MyAxB(n,m);
//Console.Write(sum);