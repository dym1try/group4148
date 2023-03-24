// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// Просим ввести первое число
Console.WriteLine("Введите первое число: ");
// Считываем 1 данные с консоли
string? inLine1 = Console.ReadLine();
// Просим ввести второе число
Console.WriteLine("Введите второе число: ");
// Считываем 2 данные с консоли
string? inLine2 = Console.ReadLine();

// Проверяем, что данные не пустые
if (inLine1 != null && inLine2 != null)
{
    // Парсим 2 переменных
    int num1 = int.Parse(inLine1);
    int num2 = int.Parse(inLine2);
    // Сравниваем числа
    if (num1 < num2)
    {
        Console.WriteLine("Первое число меньше, второе больше.");
    }
    else
    {
        Console.WriteLine("Первое число больше, второе меньше.");
    }

}
