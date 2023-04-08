// Задача №28   Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

using System.Numerics; // подключаем внешний модуль для большого целого
//Чтение данных консоли
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
// Метод вывода результата
void PrintResult(string msg, BigInteger res)
{
    Console.WriteLine(msg + res);
}

// Подсчет произведения
BigInteger Factor(int numA)
{
    BigInteger sum = 1;
    for (int i = 1; i <= numA; i++)
    {
        sum = sum * i; //
    }
    return sum;
}


int numberA = ReadData("Введите положительное число А: ");
BigInteger res1 = Factor(numberA);
PrintResult("Произведение всех чисел от 1 до А: ", res1);