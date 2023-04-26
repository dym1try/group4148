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


//////////////////////////////////////////////////////////////////////////////////////////////
// Задача 30. Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

Console.Clear();

int ReadData(string message) //
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

void Print1DArr(int[] arr) // печать массива в []
{
     Console.Write("[");
     for (int i =0; i <arr.Length -1; i++)
     {
          Console.Write(arr[i]+",");
     } 
     Console.WriteLine(arr[arr.Length-1]+"]");              
}

int[] Gen1DArr(int len, int top, int but) // генератор массива - длина, верх, низ
{
    int[] res = new int[len];
    for(int i=0; i<len;i++)
    {
        res[i] = new Random().Next(but,top+1);
    }
    return res;
}

int lenArr = ReadData("Введите длину массива: ");
int[] arr = Gen1DArr(lenArr,1,0);
Print1DArr(arr);
///////////////////////////////////////////////////////////////////////////////////////
// Задача №31  Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int globPosSum = 0; // задаем глобальные переменные // Метод 1 - через глобальные переменные globPosSum, globNegSum
int globNegSum = 0; // и ставим их в начало программы

int[] Gen1DArr(int len, int minValue, int maxValue) // генератор массива - длина, верх, низ
{
    if (minValue > maxValue) // меняем значения местами, если мин и макс введены неправильно
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }

    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
    }
    return arr;
}

void Print1DArr(int[] arr) // печать массива в []
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void NegPosSumV1(int[] arr) // Метод 1 - через глобальные переменные globPosSum, globNegSum
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            globPosSum += arr[i];
        }
        else
        {
            globNegSum += arr[i]; // то же самое, что и: globNegSum=globNegSum+arr[i];
        }
    }

}

int[] NegPosSumV2(int[] arr) // Метод 2 - через инкапсуляцию данных
{
    int positivSum = 0; // вводим ЛОКАЛЬНЫЕ переменные
    int negativSum = 0; // 
    int[] outArr = new int[2]; // создаем массив из 2 элементов для вывода данных 
                               // (т.к. мы можем вывести из метода только одно значение)
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positivSum += arr[i];
        }
        else
        {
            negativSum += arr[i]; // то же самое, что и: negativSum=negativSum+arr[i];
        }
    }
    outArr[0] = positivSum; // записываем значения в элементы массив
    outArr[1] = negativSum;
    return outArr; // возвращаем массив
}
(int positiv, int negativ) NegPosSumV3(int[] arr) // Метод 3 - через ТИПЫ данных
{
    int positivSum = 0; // вводим ЛОКАЛЬНЫЕ переменные
    int negativSum = 0; // 
    int[] outArr = new int[2]; // создаем массив из 2 элементов для вывода данных 
                               // (т.к. мы можем вывести из метода только одно значение)
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positivSum += arr[i];
        }
        else
        {
            negativSum += arr[i]; // то же самое, что и: negativSum=negativSum+arr[i];
        }
    }

    return(positivSum,negativSum); // возвращаем переменные
}


int[] testArr = Gen1DArr(12, -9, 9);

Print1DArr(testArr);
NegPosSumV1(testArr);

(int positiv, int negativ) sum = NegPosSumV3(testArr); // Метод 3 - через ТИПЫ данных

int[] res = NegPosSumV2(testArr); // создаем массив, вызываем метод V2 и передаем ему тестовый массив

Console.WriteLine("Сумма положительных чисел в массиве (v1): " + globPosSum); //  Метод 1 - через глобальные переменные globPosSum, globNegSum
Console.WriteLine("Сумма отрицательных чисел в массиве (v1): " + globNegSum);

Console.WriteLine("Сумма положительных чисел в массиве (v2): " + res[0]); // Метод 2 - через инкапсуляцию данных
Console.WriteLine("Сумма отрицательных чисел в массиве (v2): " + res[1]);

Console.WriteLine("Сумма положительных чисел в массиве (v3): " + sum.positiv); // Метод 3 - через ТИПЫ данных
Console.WriteLine("Сумма отрицательных чисел в массиве (v3): " + sum.negativ);

////////////////////////////////////////////////////////////////////////////////////////
// Задача №32  Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.


//Ввод длины массива
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
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

//Заполнение массива
int[] Gen1DArray(int len, int top, int but)
{
    int[] res=new int[len];
    for(int i=0; i<len; i++)
    {
        res[i]= new Random().Next(but, top+1);
    }
    return res;
}
void InversArrRef(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = arr[i]*(-1);
    }
}

int lenArr = ReadData("Введите длину массива: ");
int[] arr = Gen1DArray(lenArr,999,-999);
Print1Darray(arr);
InversArrRef(arr);
Print1Darray(arr);

/////////////////////////////////////////////////////////////////////////////
// Задача №33 Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// Например: 4; массив [6, 7, 19, 345, 3] -> нет   ///    -3; массив [6, 7, 19, 345, 3] -> да

//Ввод числа
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
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

//Заполнение массива
int[] Gen1DArray(int len, int top, int but)
{
    int[] res=new int[len];
    for(int i=0; i<len; i++)
    {
        res[i]= new Random().Next(but, top+1);
    }
    return res;
}

void SearchElmArr(int[] arr, int numN)
{
    bool elFind = false;
    for(int i=0; i<arr.Length; i++)
    {          
        if(numN == arr[i])
        {
            Console.WriteLine("элемент найден, ячейка: "+ i);
            elFind = true;
            //break;
        }
    }
    if (elFind == false)
    {
        Console.WriteLine("элемент не найден");
    } 
}

int lenArr = ReadData("Введите длину массива: ");
int[] arr = Gen1DArray(lenArr,9,-9);
Print1Darray(arr);
int num = ReadData("Введите искомый элемент: ");
SearchElmArr(arr, num);

//////////////////////////////////////////////////////////////////////////////
// Задача №35 Задайте одномерный массив из 123 случайных  чисел. Найдите количество
// элементов массива, значения которых лежат в отрезке [10,99].

// //Метод печати одномерного массива
// void Print1Darray(int []arr)
// {
//     Console.Write("[");
//     for(int i = 0; i<arr.Length-1; i++)
//     {
//         Console.Write(arr[i]+",");
//     }
//     Console.WriteLine(arr[arr.Length-1] + "]");
// }

// //Заполнение массива
// int[] Gen1DArray(int len, int top, int but)
// {
//     int[] res=new int[len];
//     for(int i=0; i<len; i++)
//     {
//         res[i]= new Random().Next(but, top+1);
//     }
//     return res;
// }

// //Подсчёт кол-ва в массиве
// int ElmInRange(int[] arr, int min, int max)
// {
//     int res = 0;
//     for(int i=0; i<arr.Length; i++)
//     {   
//         if(arr[i]<=max && arr[i]>=min)
//         {
//             res++;
//         }
//     }
//     return res;
// }

// int[] arr = Gen1DArray(123,1000,0);
// Print1Darray(arr);
// int res = ElmInRange(arr, 10, 99);
// Console.WriteLine("Элементов, лежащих в границах [10;99]: "+ res);

int[] Gen1DArr(int len, int top, int but)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1);
    }
    return res;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int SerchElementInArr(int[] arr)
{
    int count = 0;
    int minValue = 10;
    int maxValue = 99;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= minValue && arr[i] <= maxValue)
        {
            count++;
        }
    }
    return count;
}

int[] testArr = Gen1DArr(123, 1000, 1);
Print1DArr(testArr);
Console.WriteLine(SerchElementInArr(testArr));

///////////////////////////////////////////////////////////////////
// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.  
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0        * Найдите все пары в массиве и выведите пользователю

// В конце 5 семинара Вы прочитали это Д\З, как сумму ЧЕТНЫХ позиций. В семинаре pdf и в ЛК написано про
// НЕЧЕТНЫЕ... Решил сделать подсчет нечетных.

//Ввод длины массива
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//Метод печати одномерного массива
void Print1Darray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Заполнение массива
int[] Gen1DArray(int len, int top, int but)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1);
    }
    return res;
}

int SumElmOddPos(int[] arr) // считаем сумму элементов, стоящих на нечётных позициях.
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum += arr[i];
    }
    return sum;
}
int lenArr = ReadData("Введите длину массива: ");
int[] arr = Gen1DArray(lenArr, 999, 100);
Print1Darray(arr); // выводим массив
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + SumElmOddPos(arr));

/////////////////////////////////////////////////////////////////////////////

// Задача №37
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int res = int.Parse(Console.ReadLine() ?? ("0"));
//     return res;
// }

// int[] Gen1Darray(int len, int minValue, int maxValue)
// {
//     if (minValue > maxValue)
//     {
//         int buf = minValue;
//         minValue = maxValue;
//         maxValue = buf;
//     }
//     Random rnd = new Random();
//     int[] arr = new int[len];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(minValue, maxValue + 1);
//     }
//     return arr;
// }

// void Print1DArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ",");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// int[] ConverArr(int[] arr)
// {
//     int len = (arr.Length % 2 == 0) ? arr.Length / 2 : arr.Length / 2 + 1;
//     int[] outArr = new int[len];

//     for (int i = 0; i < len; i++)
//     {
//         outArr[i] = arr[i] * arr[arr.Length - 1 - i];
//     }

//     return outArr;
// }

// int Length = ReadData("Введите длину массива: ");
// int[] arr = Gen1Darray(Length, 999, -999);
// Print1DArray(arr);
// int[] newArr = ConverArr(arr);
// Print1DArray(newArr);

int[] Gen1DArr(int len, int top, int but)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1);
    }
    return res;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] ConvertArr(int[] array)
{
    int len = (array.Length % 2 == 0) ? array.Length / 2 : array.Length / 2 + 1;
    int[] outArr = new int[len];

    for (int i = 0; i < len; i++)
    {
        outArr[i] = array[i] * array[array.Length - 1 - i];
    }
    return outArr;
}

int[] testArr = Gen1DArr(12, 20, 1);
Print1DArr(testArr);
Print1DArr(ConvertArr(testArr));
//Console.WriteLine();

//////////////////////////////////////////////////////////////////////////////////

// №38 ДЗ. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76         [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.

Console.Clear();

//Ввод длины массива
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//Метод печати одномерного массива
void Print1Darray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Заполнение массива ВЕЩЕСТВЕННЫМИ ЧИСЛАМИ
double[] Gen1DArray(int len, int top, int but)
{
    double[] res = new double[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().NextDouble() * 200 - 100; // Задал диапазон от -100 до 100
    }
    return res;
}

double DiffMinMax(double[] arr) // Находим минимум, максимум и разницу между ними
{
    double res = 0;
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
        if (max < arr[i]) max = arr[i];

    }
    res = max - min;
    return res;
}

int lenArr = ReadData("Введите длину массива: ");
double[] arr = Gen1DArray(lenArr, 999, 100);
Print1Darray(arr); // выводим массив
DiffMinMax(arr);
Console.WriteLine("Разница между максимальным и минимальным элементами: " + DiffMinMax(arr));

//////////////////////////////////////////////////////////////////////////////////////////

// Задача №39 Напишите программу, которая перевернёт одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.) Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1) менять числа местами в исходном массиве; 
// 2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.

//Метод печати одномерного массива
void Print1Darray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Заполнение массива
int[] Gen1DArray(int len, int top, int but)
{
    int[] res = new int[len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(but, top + 1);
    }
    return res;
}

void SwapArray1(int[] arr)// 1 метод - изменение исходного массива
{
    int buf = 0;//вводим буферную переменную
    for(int i=0; i<arr.Length/2;i++)// проходим половину массива
    {
        //(arr[i], arr[arr.Length-1-i]) = (arr[arr.Length-1-i], arr[i]); можно и так, но на старых может не работать
        buf = arr[i];
        arr[i] = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = buf;
    }
}

int[] SwapNewArray2(int[] arr)
{
    int[] outarr = new int[arr.Length];// создаем новый массив той же длины
    for (int i = 0; i < arr.Length; i++)
    {
        outarr[i]=arr[arr.Length-i-1];
    }
    return outarr;
}

int[] arr = Gen1DArray(15, 999, 100); // Сами задаем параметры массива
Print1Darray(arr); // выводим исходный массив
SwapArray1(arr);// выполняем первый метод
Print1Darray(arr); // выводим измененный массив по первому методу

SwapNewArray2(arr);// выполняем второй метод
Print1Darray(arr); // выводим измененный массив по второму методу

/////////////////////////////////////////////////////////////////////////////////////

// Задача №40  Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

Console.Clear();

// Чтение данных с консоли
int ReadData(string message) //
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

bool TrianTest(int a, int b, int c)
{
    if ((a < b + c) && (b < a + c) && (c < a + b))// или проще одной строкой return ((a+b>c)&& (a+c>b)&& (b+c>a));
    {
        return true;
    }
    return false;
}

int a = ReadData("Введите сторону a: ");
int b = ReadData("Введите сторону b: ");
int c = ReadData("Введите сторону c: ");

TrianTest(a, b, c);

if (TrianTest(a, b, c))
{
    Console.WriteLine("Такой треугольник существует.");
}
else
{
    Console.WriteLine("Такого треугольника не существует.");
}
//////////////////////////////////////////////////////////////////////////////////////
