// Задача №26   Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.

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
    Console.WriteLine(msg+res);
}

// Подсчет количества цифр
int CountDigit(int number)
{
    int result = 0;
    while(number>0)
    {
        result++;
        number=number/10;
    }
    return result;
}

int numberA = ReadData("Введите число А: ");
int res1=CountDigit(numberA);
PrintResult("Количество цифр: ", res1);