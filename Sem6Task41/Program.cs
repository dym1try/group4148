// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2            -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.
Console.Clear();

//спрашиваем длину массива
Console.Write("Введите количество элементов массива M: ");
int cnt = int.Parse(Console.ReadLine() ?? "0");

// запрашиваем значения массива у пользователя
int[] arr = new int[cnt];// создаем массив
int cntPos = 0;//вводим переменную для подсчета положительных чисел
for (int i=0; i<cnt; i++)
    {
        Console.Write("Введите " + i + "-й элемент массива: ");
        arr[i] = int.Parse(Console.ReadLine() ?? "0");
        if (arr[i]>0)
        {
            cntPos++;
        }
    }

//Метод печати одномерного массива
void Print1Darray(int []arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i]+",");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}
Print1Darray(arr);
Console.WriteLine("Количество положительных чисел: " + cntPos);

// решение из класса =================================================================================

using System.Text.RegularExpressions; //без явного указания сборки не работают регулярные выражения.

int taps = ReadData("Введите количество нажатий");
string inputLine = ReadLineData("Введите любые символы с клавиатуры.");
Console.WriteLine(inputLine);
FindNumbersInString(inputLine,taps);

//Методы
int ReadData(string msg)//метод запрашивает и ситывает данные с консоли
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//метод считывает нажатие клавиш на клавиатуре заданное количество раз 
// и собирает данные в строку через запятую
string ReadLineData(string msg)
{
    Console.WriteLine(msg);
    string line = "";
    for (int i = 0; i < taps; i++)
    {
        var key = Console.ReadKey(true); //параметр true указан для того, чтобы после нажатия клавиш ничего не появлялось в консоли
        line = line + String.Format(key.KeyChar.ToString()) + ",";
    }
    line = line.TrimEnd(','); //кусь последнюю запятую
    return line;
}

void FindNumbersInString(string str, int count)//метод для поиска десятичных цифр в строке с помощью регулярных выражений
{
    Regex regex = new Regex(@"\d");//задаем для поиска параметр "любая десятичная цифра"
    MatchCollection matches = regex.Matches(str); //задаем коллекциюЮ состоящую из найденных по условию выражений 
    int posNums = 0;
    if (matches.Count > 0) //если цифры найдены, то накапливаем результат. Каждая найденная цифра +1 к итогу.
    {
        foreach (Match match in matches)
        {
            posNums = posNums + 1;
        }
        Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов найдено чисел: {posNums}");
    }
    else
    {
        Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов чисел не найдено");
    }
}