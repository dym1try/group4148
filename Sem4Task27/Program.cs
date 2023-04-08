// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11  // 82 -> 10 // 9012 -> 12
// * Сделать оценку времени алгоритма через вещественные числа и строки 
//Чтение данных консоли
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
// Метод вывода результата
void PrintResult(string msg, int res)
{
    Console.WriteLine(msg + res);
}

// Подсчет суммы цифр числа
int CountDigit(int number)
{
    int result = 0;
    while(number>0)
    {
        int cif = number%10;
        number=number/10;
        result = result + cif;
    }
    return result;
}

int numberA = ReadData("Введите число А: ");

DateTime d1 = DateTime.Now; // Оценка времени выполнения - старт
int res1 = CountDigit(numberA);
Console.WriteLine(DateTime.Now - d1); // время - финиш

PrintResult("Сумма всех цифр в числе А: ", res1);