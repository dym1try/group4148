// Напишите программу, которая на вход принимает
// число и выдаёт его квадрат.
// Просим ввести число
Console.WriteLine("Введите число: ");
// Считываем данные с консоли
string? inLine = Console.ReadLine();
// Проверяем, что данные не пустые
if (inLine != null)
{
    // Парсим введенное число
    int inNumber = int.Parse(inLine);
    // Находим квадрат
    int quadNumber = inNumber * inNumber;
    // Выводим данные
    Console.Write("Квадрат числа: ");
    Console.WriteLine(quadNumber);
}