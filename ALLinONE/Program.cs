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
