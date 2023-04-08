using System.Numerics; // подключаем внешний модуль для большого целого

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

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго.
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
    // Сравниваем первое число и квадрат второго
    if (num1 == num2 * num2)
    {
        Console.WriteLine("Первое число является квадратом второго.");
    }
    else
    {
        Console.WriteLine("Первое число не является квадратом второго.");
    }

}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
//////////////////////////////////////////////////////////////////////////////////////////////////
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
/////////////////////////////////////////////////////////////////////////////////////////////////
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
    int max = num1;
    // Сравниваем переменные
     if (num2 > max) max = num2;
     if (num3 > max) max = num3;
   
Console.Write("Максимальное число: ");
Console.WriteLine(max);

}
////////////////////////////////////////////////////////////////////////////////////////////////
// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.

Console.WriteLine("Введите положительное число: ");
// Считываем данные с консоли
string? numNLine = Console.ReadLine();
// Проверяем, что данные не пустые
if (numNLine != null)
{
    int numN = int.Parse(numNLine);
    int startNum = numN * (-1);
    string res = string.Empty;
    while (startNum <= numN)
    {
        res = res + startNum + " ";
        startNum = startNum + 1;
    }

Console.WriteLine(res);

}
///////////////////////////////////////////////////////////////////////////////////////////////
// Напишите программу, которая на вход принимает число и выдаёт, является ли число
// чётным (делится ли оно на два без остатка).
// Просим ввести число
Console.WriteLine("Введите число: ");
// Считываем данные с консоли
string? inLine = Console.ReadLine();


// Проверяем, что данные не пустые
if (inLine != null)
{
    // Парсим переменную
    int num = int.Parse(inLine);
    // Вводим переменную ost - остаток от деления на 2
    double ost = num%2;
    
    // Сравниваем эту переменную с 0
    if (ost == 0)
    {
        Console.WriteLine("Ваше число чётное.");
    }
    else
    {
        Console.WriteLine("Ваше число нечётное.");
    }

}
////////////////////////////////////////////////////////////////////////////////////////////////
// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе
// показывает последнюю цифру этого числа.
// Просим ввести число
Console.WriteLine("Введите трехзначное число: ");
// Считываем данные с консоли
string? inLine = Console.ReadLine();
// Проверяем, что данные не пустые
if (inLine != null)
{
    // Парсим введенное число
    int num = int.Parse(inLine);
    // Делим число на 10 и выводим остаток от деления
    int res = num%10;
    Console.Write("Последняя цифра числа: ");
    Console.Write(res);

}
//////////////////////////////////////////////////////////////////////////////////////////
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
////////////////////////////////////////////////////////////////////////////////////////////////////
//Задача №9
//Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

System.Random numSintezator = new Random();
int rndNum = numSintezator.Next(10,100);
Console.WriteLine(rndNum);
int firstNum = rndNum/10;
int secondNum = rndNum%10;

if(firstNum>secondNum)
{
    Console.WriteLine("Первое число больше");
}
else
{
    Console.WriteLine("Второе число больше");
} 

// Вариант 2
char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);
firstNum = (int)(digits[0])-48;
secondNum = (int)(digits[1])-48;

// Тирнарный оператор     \ если да    \  если нет
// переменная = (условие?) <Значение 1>:<значение 2>;
int res = (firstNum>secondNum)?firstNum:secondNum;
Console.WriteLine(res);

// Вариант 3
// Табличный, с готовым заполненным массивом
int rndNumberArr = numSintezator.Next(10, 100);
Console.WriteLine(rndNumberArr);
int[] indxAnsw = new int[90];
indxAnsw[0] = 1;indxAnsw[1] = 1;indxAnsw[2] = 2;indxAnsw[3] = 3;indxAnsw[4] = 4;indxAnsw[5] = 5;indxAnsw[6] = 6;indxAnsw[7] = 7;indxAnsw[8] = 8;indxAnsw[9] = 9;
indxAnsw[10] = 2;indxAnsw[11] = 2;indxAnsw[12] = 2;indxAnsw[13] = 3;indxAnsw[14] = 4;indxAnsw[15] = 5;indxAnsw[16] = 6;indxAnsw[17] = 7;indxAnsw[18] = 8;indxAnsw[19] = 9;
indxAnsw[20] = 3;indxAnsw[21] = 3;indxAnsw[22] = 3;indxAnsw[23] = 3;indxAnsw[24] = 4;indxAnsw[25] = 5;indxAnsw[26] = 6;indxAnsw[27] = 7;indxAnsw[28] = 8;indxAnsw[29] = 9;
indxAnsw[30] = 4;indxAnsw[31] = 4;indxAnsw[32] = 4;indxAnsw[33] = 4;indxAnsw[34] = 4;indxAnsw[35] = 5;indxAnsw[36] = 6;indxAnsw[37] = 7;indxAnsw[38] = 8;indxAnsw[39] = 9;
indxAnsw[40] = 5;indxAnsw[41] = 5;indxAnsw[42] = 5;indxAnsw[43] = 5;indxAnsw[44] = 5;indxAnsw[45] = 5;indxAnsw[46] = 6;indxAnsw[47] = 7;indxAnsw[48] = 8;indxAnsw[49] = 9;
indxAnsw[50] = 6;indxAnsw[51] = 6;indxAnsw[52] = 6;indxAnsw[53] = 6;indxAnsw[54] = 6;indxAnsw[55] = 6;indxAnsw[56] = 6;indxAnsw[57] = 7;indxAnsw[58] = 8;indxAnsw[59] = 9;
indxAnsw[60] = 7;indxAnsw[61] = 7;indxAnsw[62] = 7;indxAnsw[63] = 7;indxAnsw[64] = 7;indxAnsw[65] = 7;indxAnsw[66] = 7;indxAnsw[67] = 7;indxAnsw[68] = 8;indxAnsw[69] = 9;
indxAnsw[70] = 8;indxAnsw[71] = 8;indxAnsw[72] = 8;indxAnsw[73] = 8;indxAnsw[74] = 8;indxAnsw[75] = 8;indxAnsw[76] = 8;indxAnsw[77] = 8;indxAnsw[78] = 8;indxAnsw[79] = 9;
indxAnsw[80] = 9;indxAnsw[81] = 9;indxAnsw[82] = 9;indxAnsw[83] = 9;indxAnsw[84] = 9;indxAnsw[85] = 9;indxAnsw[86] = 9;indxAnsw[87] = 9;indxAnsw[88] = 9;indxAnsw[89] = 9;

Console.WriteLine(indxAnsw[rndNumberArr-10]);

////////////////////////////////////////////////////////////////////////////////////////////////////

// №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1 


Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
int scndNum = (num%100 - num%10) / 10; // Вычитаем остатки от деления друг из друга и делим их на 10.

Console.WriteLine("Ваше число: " + num);
Console.WriteLine("Вторая цифра: " + scndNum);

/////////////////////////////////////////////////////////////////////////////////////////////
// //Задача №11
// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа. 
int num = new Random().Next(100,1000);
int fisNum = num/100;
int lasNum = num%10;
int newNum = fisNum*10 + lasNum;
Console.WriteLine(num);
Console.WriteLine(newNum);

///////////////////////////////////////////////////////////////////////////////////////
// Задача №12/ Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе
// число кратным первому. Если второе число
// некратно первому, то программа выводит остаток от
// деления. 
Console.WriteLine("Введите первое число: ");
// Более БЫСТРЫЙ метод проверки непустого ввода
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите второе число: ");
// Более медленный метод проверки непустого ввода
int num2 = Convert.ToInt32(Console.ReadLine());

bool res = (num1%num2 == 0);

if (res)
{
    Console.WriteLine("Второе число кратно первому.");
}
else
{
    Console.WriteLine("Второе число не кратно первому, остаток:" + num1%num2);
}
///////////////////////////////////////////////////////////////////////////////////////////

// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// * Сделать вариант для числа длиной до 10 цифр не используя char или string


Console.WriteLine("Введите (целое положительное*) число длиной до 10 цифр: ");
long num = int.Parse(Console.ReadLine() ?? "0");

// Задаем переменную third
long third = -1;
// 
if (num < 100)
{
 Console.Write("В Вашем числе нет третьей цифры.");
}
else
{
    if (num >= 100 && num <= 999) third = num % 10; // для 3-значных чисел

    if (num >= 1000 && num <= 9999) third = (num % 100 - num % 10) / 10; // для 4-значных чисел

    if (num >= 10000 && num <= 99999) third = (num % 1000 - num % 100) / 100; // для 5-значных чисел

    if (num >= 100000 && num <= 999999) third = (num % 10000 - num % 1000) / 1000; // для 6-значных чисел

    if (num >= 1000000 && num <= 9999999) third = (num % 100000 - num % 10000) / 10000; // для 7-значных чисел

    if (num >= 10000000 && num <= 99999999) third = (num % 1000000 - num % 100000) / 100000; // для 8-значных чисел

    if (num >= 100000000 && num <= 999999999) third = (num % 10000000 - num % 1000000) / 1000000; // для 9-значных чисел
    
    if (num >= 1000000000 && num <= 9999999999) third = (num % 100000000 - num % 10000000) / 10000000; // для 10-значных чисел

    Console.Write("Третья цифра числа: " + third);
}

/////////////////////////////////////////////////////////////////////////////////////
// Задача №14
// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и 23. 

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()??"0");
bool test1 = (num%7 == 0);
bool test2 = (num%23 == 0);

if(test1 && test2)
{
    Console.WriteLine("Число кратно и 7, и 23");
}
else
{
    Console.WriteLine("Число не кратно и 7, и 23");    
}
//////////////////////////////////////////////////////////////////////////////////////////////
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

///////////////////////////////////////////////////////////////////////////////////////////
// Задача №16
// Напишите программу, которая принимает на вход
// два числа и проверяет, является ли одно число квадратом другого. 

Console.WriteLine("Введите первое число: ");
// Более БЫСТРЫЙ метод проверки непустого ввода
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");

void SqrtTest(int a, int b)
{
    if (a == b * b)
        Console.WriteLine(a + " это квадрат " + b);
    else
        Console.WriteLine(a + " это не квадрат " + b);
}
SqrtTest(num1, num2);
SqrtTest(num2, num1);
///////////////////////////////////////////////////////////////////////////////////////////////
// Задача №17
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Метод, который вернет нам значение переменной, 
// читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

void PrintQuoterTest(int x, int y) // печатаем тест четверти
{
    if (x > 0 && y > 0) Console.WriteLine("Точка в 1 четверти.");
    if (x > 0 && y < 0) Console.WriteLine("Точка в 2 четверти.");
    if (x < 0 && y < 0) Console.WriteLine("Точка в 3 четверти.");
    if (x < 0 && y > 0) Console.WriteLine("Точка в 4 четверти.");

}

int coordX = ReadData("Введите координату X");
int coordY = ReadData("Введите координату Y");
PrintQuoterTest(coordX,coordY);

//////////////////////////////////////////////////////////////////////////

// Задача №18
// Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
// печатаем тест четверти
void PrintCoordTest(int quater)
{
    if (quater == 1) Console.WriteLine("x > 0 , y > 0");
    if (quater == 2) Console.WriteLine("x > 0 , y < 0");
    if (quater == 3) Console.WriteLine("x < 0 , y < 0");
    if (quater == 4) Console.WriteLine("x < 0 , y > 0");
}

int quaterINT = ReadData("Введите Номер Четверти: ");


PrintCoordTest(quaterINT);

/////////////////////////////////////////////////////////////////////
// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да    * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num < 10000 || num > 99999)// Проверка на пятизначность
{
 Console.Write("Ваше число - не пятизначное.");
}
else // Если пятизначное, то преобразуем в строку и в массив
{
char[] digits = num.ToString().ToCharArray();

if (digits[0] == digits[4] && digits[1] == digits[3]) // проверка на палиндром
{
 Console.Write("Ваше число - палиндром.");
}
else
{
 Console.Write("Ваше число - не палиндром.");
}
}
/////////////////////////////////////////////////////////////////////////////////

// Задача №20
// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
// метод принимает 4 переменных и возвращает одну
double CalcLen2D(int x1, int y1, int x2, int y2)
{
    //     корень    возведение во 2 степ.   то же самое по простому
    return Math.Sqrt(Math.Pow((x1 - x2), 2) + (y1-y2) * (y1-y2));
}

int x1 = ReadData("Введите координату X точки А: ");
int y1 = ReadData("Введите координату Y точки А: ");
int x2 = ReadData("Введите координату X точки B: ");
int y2 = ReadData("Введите координату Y точки B: ");

Console.WriteLine ("Расстояние между точками A и B: " + CalcLen2D(x1,y1,x2,y2));

////////////////////////////////////////////////////////////////////////////////////////
// Задача №21
// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
// метод принимает 6 переменных и возвращает одну
double CalcLen3D(int x1, int y1, int x2, int y2, int z1, int z2)
{
    //     корень    возведение во 2 степ.   
    return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
}

int x1 = ReadData("Введите координату X точки А: ");
int y1 = ReadData("Введите координату Y точки А: ");
int z1 = ReadData("Введите координату Z точки A: ");

int x2 = ReadData("Введите координату X точки B: ");
int y2 = ReadData("Введите координату Y точки B: ");
int z2 = ReadData("Введите координату Z точки B: ");


Console.WriteLine ("Расстояние между точками A и B: " + CalcLen3D(x1,y1,x2,y2,z1,z2));

//////////////////////////////////////////////////////////////////////////////////////

// 22

//////////////////////////////////////////////////////////////////////////////////////
// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом

Console.WriteLine("Введите число: "); // Считываем данные с консоли
int num = int.Parse(Console.ReadLine()??"0");

int startNum = 1; // задаем первое число в ряду
string res = string.Empty; // создаем пустую строку для ряда просто значений
while (startNum <= num)
    {
        res = res + startNum + " ";
        startNum = startNum + 1;
    }

Console.WriteLine(res);

string resKub = string.Empty; // создаем пустую строку для ряда кубов
int startNum3 = 1; // снова задаем первое число в ряду 
while (startNum3 <= num)
    {
        resKub = resKub + Math.Pow(startNum3, 3) + " ";
        startNum3 = startNum3 + 1;
    }

Console.WriteLine(resKub);

////////////////////////////////////////////////////////////////////////////////////
// Задача №24    // Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

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

long SumSimple(int numA)
{
    long sum = 0;
    for(int i =1; i<=numA;i++)
    {
        sum+=i;
        //sum=sum+i;
    }
    return sum;
}

long SumGauss(int numA)
{
    return ((1+(long)numA)*(long)numA)/2;
}

int numberA=ReadData("Введите число A: ");

DateTime d1 = DateTime.Now;
long res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
long res2 = SumGauss(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до A(простой метод):", (int)res1);
PrintResult("Сумма чисел от 1 до A(простой Гаусса):", (int)res2);

//////////////////////////////////////////////////////////////////////////////

// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// 3, 5 -> 243 (3⁵)  // 2, 4 -> 16

Console.Clear();

// Чтение данных с консоли
int ReadData(string message) //
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

// Метод вывода результата
void PrintResult(string msg, long res)
{
    Console.WriteLine(msg + res);
}


long MyPowSimple(int a, int b)
{
    long res = 1;
    while (b > 0)
    {
        res = res * a;
        b = b - 1;
    }
    return res;
}

long MyPowFormula(int a, int b)
{
    long resf = 1;
    resf = (long)Math.Pow(a, b);
    return resf;
}

int a = ReadData("Введите число a: ");
int b = ReadData("Введите число b: ");
long res = MyPowSimple(a, b);
long resf = MyPowFormula(a, b);
PrintResult("Число a в степени b (простой метод): ", res);
PrintResult("Число a в степени b (метод с формулой): ", resf);


///////////////////////////////////////////////////////////////////////////////
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

////////////////////////////////////////////////////////////////////////////////////////////////////
// 27
/////////////////////////////////////////////////////////////////////////////////////////////////
// Задача №28   Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

// using System.Numerics; // подключаем внешний модуль для большого целого - для работы снять комменты
//Чтение данных консоли
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
// Метод вывода результата
void PrintResult(string msg, BigInteger res)
{
    Console.WriteLine(msg + res);
}

// Подсчет произведения
BigInteger Factor(int numA)
{
    BigInteger sum = 1;
    for (int i = 1; i <= numA; i++)
    {
        sum = sum * i; //
    }
    return sum;
}


int numberA = ReadData("Введите положительное число А: ");
BigInteger res1 = Factor(numberA);
PrintResult("Произведение всех чисел от 1 до А: ", res1);

//////////////////////////////////////////////////////////////////////////////////////////////
// 29
