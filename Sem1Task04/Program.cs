// НЕ РЕШИЛ
// Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
// Просим ввести первое число
Console.WriteLine("Введите первое число: ");
// Считываем 1 данные с консоли
string? inLine1 = Console.ReadLine();
// Просим ввести второе число
Console.WriteLine("Введите второе число: ");
// Считываем 2 данные с консоли
string? inLine2 = Console.ReadLine();
// Просим ввести третье число
Console.WriteLine("Введите третье число: ");
// Считываем 3 данные с консоли
string? inLine3 = Console.ReadLine();
// Проверяем, что данные не пустые
if (inLine1 != null && inLine2 != null && inLine3 != null)
{
    // Парсим 3 переменных
    int num1 = int.Parse(inLine1);
    int num2 = int.Parse(inLine2);
    int num3 = int.Parse(inLine3);

    // Задаем переменную МАКС
    int maxnum = num1;
    // Сравниваем переменные
     if (maxnum > num2)
     {
        int maxnum = num2;
     }
     else
     {
     if (maxnum > num3)
     {
        int maxnum = num3;
     }

     }
Console.Write("Максимальное число: ");
Console.WriteLine(maxnum);

}