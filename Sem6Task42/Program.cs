// Задача №42  Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Clear();

// Чтение данных с консоли
int ReadData(string message) //
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

string DecToBin (int num)// на вход принимаем int, на выходе string
{
    string res=String.Empty;
    while(num>0)
    {
        res=res+num%2;
        num=num/2;
    }
    return res;
}

int num = ReadData("Введите число: ");

Console.WriteLine("Ваше число в двоичном формате через метод: " + DecToBin(num));

Console.WriteLine("Ваше число в двоичном формате через конверсию: " + Convert.ToString(num,2)); // самый простой