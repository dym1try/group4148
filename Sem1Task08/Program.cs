// Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.

Console.WriteLine("Введите положительное число: ");
// Считываем данные с консоли
string? numNLine = Console.ReadLine();
// Проверяем, что данные не пустые
if (numNLine != null)
{
    int numN = int.Parse(numNLine); // парсим введенное число
    int startNum = 2; // задаем первое четное число в ряду
    string res = string.Empty; // создаем пустую строку
    while (startNum <= numN)
    {
        res = res + startNum + " ";
        startNum = startNum + 2;
    }

Console.WriteLine(res);

}
