// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// Просим ввести число
Console.WriteLine("Введите число: ");
// Считываем данные с консоли
string? inLine = Console.ReadLine();
// Проверяем, что данные не пустые
if (inLine != null)
{
    // Парсим введенное число
    int inNumber = int.Parse(inLine);
    // Сравниваем число и печатаем день недели
    if (inNumber == 1)
    {
        Console.WriteLine("Понедельник.");
    }
    if (inNumber == 2)
    {
        Console.WriteLine("Вторник.");
    }
    if (inNumber == 3)
    {
        Console.WriteLine("Среда.");
    }
    if (inNumber == 4)
    {
        Console.WriteLine("Четверг.");
    }
    if (inNumber == 5)
    {
        Console.WriteLine("Пятница.");
    }
    if (inNumber == 6)
    {
        Console.WriteLine("Суббота.");
    }
    if (inNumber == 7)
    {
        Console.WriteLine("Воскресенье.");
    }
    // Проверка правильности ввода
    if (inNumber != 1 && inNumber != 2 && inNumber != 3 && inNumber != 4 && inNumber != 5 && inNumber != 6 && inNumber != 7)
    {
        Console.WriteLine("Неправильный ввод. Введите целое число от 1 до 7.");
    }

}
