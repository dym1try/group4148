// Задача №44 Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1. Например: Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1    Если N = 7 -> 0 1 1 2 3 5 8

// Console.Clear();

// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// string Fibbanachi(int newNum)
// {
//     string res = "0 1";
//     long first = 0;
//     long last = 1;
//     for(int i = 2 ; i < newNum ; i++)
//     {
//         res += " "+(first + last);
//         (first,last) = (last,first + last);
//     }
//     return res;
// }

// string res = "";
// int newNum = ReadData("Введите число: ");
// res=Fibbanachi(newNum);
// Console.WriteLine(res);

// Задача №44
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

//  метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

//Метод построения чисел фибаначи
string FibNum(int num)
{
    string res = "0 1";
    long first = 0;
    long last = 1;

    for (int i = 2; i <= num; i++)
    {
        res = res + " " + (first + last);
        (first, last) = (last, last + first);
    }
    //i=2
    //res = 0 1 1
    // (first, last) 1 1
    //i=3
    //res = 0 1 1 2
    // (first, last) 1 2
    //i=4
    //res = 0 1 1 2 3
    // (first, last) 2 3

    return res;
}

string res = "";
int n = ReadData("Введите n");
res = FibNum(n);
Console.WriteLine(res);