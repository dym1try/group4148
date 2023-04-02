// №15 Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary

Dictionary<int, string> daysOfWeek = new Dictionary<int, string>();
daysOfWeek.Add(1, "Будний день.");
daysOfWeek.Add(2, "Будний день.");
daysOfWeek.Add(3, "Будний день.");
daysOfWeek.Add(4, "Будний день.");
daysOfWeek.Add(5, "Будний день.");
daysOfWeek.Add(6, "Выходной.");
daysOfWeek.Add(7, "Выходной.");

Console.WriteLine("Введите день недели (1-7): ");
int day = int.Parse(Console.ReadLine()??"0");

if (daysOfWeek.ContainsKey(day))
{
    Console.WriteLine(daysOfWeek[day]);
}
else
{
    Console.WriteLine("Это не день недели.");
}