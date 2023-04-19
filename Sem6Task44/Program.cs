// Задача №44 Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1. Например: Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1    Если N = 7 -> 0 1 1 2 3 5 8

// Console.Clear();

// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// string Fibbanachi(int newNum)
// {
//     string res = "0 1";
//     long first = 0;
//     long last = 1;
//     for(int i = 2 ; i < newNum ; i++)
//     {
//         res += " "+(first + last);
//         (first,last) = (last,first + last);
//     }
//     return res;
// }

// string res = "";
// int newNum = ReadData("Введите число: ");
// res=Fibbanachi(newNum);
// Console.WriteLine(res);

// Задача №44
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

//  метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

//Метод построения чисел фибаначи
string FibNum(int num)
{
    string res = "0 1";
    long first = 0;
    long last = 1;

    for (int i = 2; i <= num; i++)
    {
        res = res + " " + (first + last);
        (first, last) = (last, last + first);
    }
    //i=2
    //res = 0 1 1
    // (first, last) 1 1
    //i=3
    //res = 0 1 1 2
    // (first, last) 1 2
    //i=4
    //res = 0 1 1 2 3
    // (first, last) 2 3

    return res;
}

string res = "";
int n = ReadData("Введите n");
res = FibNum(n);
Console.WriteLine(res);

// РЕШЕНИЕ ИЗ КЛАССА ===============================================================
// * Найдите площадь треугольника образованного пересечением 3 прямых 
//   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

double K1 = ReadData("Input number K1: ");
double B1 = ReadData("Input number B1: ");
double K2 = ReadData("Input number K2: ");
double B2 = ReadData("Input number B2: ");
double K3 = ReadData("Input number K3: ");
double B3 = ReadData("Input number B3: ");
// Поиск координат пересечения
(double x, double y) pointA = CrossPoint(K1, B1, K2, B2);
(double x, double y) pointB = CrossPoint(K2, B2, K3, B3);
(double x, double y) pointC = CrossPoint(K3, B3, K1, B1);

double X1 = pointA.x;
double Y1 = pointA.y;
double X2 = pointB.x;
double Y2 = pointB.x;
double X3 = pointC.x;
double Y3 = pointC.x;
PrintData($"Cross points of 3 lines: X1= {X1}; Y1= {Y1}, X2= {X2}; Y2= {Y2}, X3= {X3}; Y3= {Y3}");
double sideA = TriangleSide(X1, Y1, X2, Y2);
double sideB = TriangleSide(X2, Y2, X3, Y3);
double sideC = TriangleSide(X3, Y3, X1, Y1);
PrintData($"The length of triangle sides: A= {sideA}; B= {sideB}, C= {sideC}");
PrintData($"The square of triangle: S= {SquareTriangle(sideA, sideB, sideC)}");

// Метод считывания введенных данных.
double ReadData(string msg)
{
    Console.Write(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}
// Метод вывода данных.
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
// комплексный метод
(double x, double y) CrossPoint(double k1, double b1, double k2, double b2)
{
    double coorX1 = (b2 - b1) / (k1 - k2);
    double coorY1 = (k1 * b2 - k2 * b1) / (k1 - k2);
    return (coorX1, coorY1);
}
//Находим стороны треугольника, разбила на 3 отдельных метода, чтобы получить сразу переменные в double.
double TriangleSide(double x1, double y1, double x2, double y2)
{
    double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return result;
}
// Находим площадь треугольника через полумериметр (p=(a + b + c) / 2 )сторон и длины сторон.
double SquareTriangle(double a, double b, double c)
{
    double squareT = Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c));
    return squareT;
}

// РЕШЕНИЕ ТРУДНОЙ ЗАДАЧИ ====================================================================
const int X1 = 0;
const int Y1 = 1;
const int X2 = 0;
const int Y2 = 1;
const int X3 = 0;
const int Y3 = 1;
const int coef = 0;
const int con = 1;
const int Line1 = 1;
const int Line2 = 2;
const int Line3 = 3;

//Вызов метода для записи чисел
double[] LineData1 = LineData(Line1);
double[] LineData2 = LineData(Line2);
double[] LineData3 = LineData(Line3);

if (IntersectLines(LineData1, LineData2,LineData3))
{
    double[] coord1 = FindCoord(LineData1, LineData2);
    Console.WriteLine($"Точка пересечений уравнений Y = {LineData1[coef]}*X+{LineData1[con]} /n Y= {LineData2[coef]}*X+{LineData2[con]}");
    Console.WriteLine($"Имеет координаты ({coord1[X1]}, {coord1[Y1]})");
    double[] coord2 = FindCoord(LineData2, LineData3);
    Console.WriteLine($"Точка пересечений уравнений Y = {LineData2[coef]}*X+{LineData2[con]} /n Y= {LineData3[coef]}*X+{LineData3[con]}");
    Console.WriteLine($"Имеет координаты ({coord2[X2]}, {coord2[Y2]})");
    double[] coord3 = FindCoord(LineData3, LineData1);
    Console.WriteLine($"Точка пересечений уравнений Y = {LineData1[coef]}*X+{LineData1[con]} /n Y= {LineData3[coef]}*X+{LineData3[con]}");
    Console.WriteLine($"Имеет координаты ({coord3[X3]}, {coord3[Y3]})");
    Console.WriteLine($"Площадь треугольника = {SqeaTriangle(coord1,coord2,coord3)}");
}

double SqeaTriangle(double[] co1, double[] co2, double[] co3)
{
    double d1 = (co2[X2] - co1[X1])*(co3[Y3]-co1[Y1]) ;
    double d2 =  (co3[X3] - co1[X1])*(co2[Y2]-co1[Y1]);
    Console.WriteLine(d1);
    Console.WriteLine(d2);
    Console.WriteLine((0.5) * (Math.Abs(d1-d2)));
    return ((0.5) * (Math.Abs(d1-d2)));
}


//Ввод числа
double ReadMSG(string msg)
{
    Console.Write(msg);
    string row = Console.ReadLine();
    double res = Convert.ToDouble(row);
    return res;
}

//Данные в пямую
double[] LineData(int NumOfLines)
{
    double[] LineData = new double[3];
    LineData[coef] = ReadMSG($"Введите k для {NumOfLines} прямой: ");
    LineData[con] = ReadMSG($"Введите b для {NumOfLines} прямой: ");
    return LineData;
}

double[] FindCoord(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[0] = (lineData1[1] - lineData2[1]) / (lineData2[0] - lineData1[0]);
    coord[1] = lineData1[0] * coord[0] + lineData1[1];
    return coord;
}

// //Поиск координат
// double[] FindCoords1(double[] LineData1, double[] LineData2)
// {
//     double[] coord1 = new double[2];
//     coord1[X1] = (LineData1[con] - LineData2[con]) / (LineData2[coef] - LineData1[coef]);
//     coord1[Y1] = LineData1[coef] * coord1[X1] + LineData1[con];
//     return coord1;
// }

// double[] FindCoords2(double[] LineData2, double[] LineData3)
// {
//     double[] coord2 = new double[2];
//     coord2[X2] = (LineData2[con] - LineData3[con]) / (LineData3[coef] - LineData2[coef]);
//     coord2[Y2] = LineData1[coef] * coord2[X2] + LineData1[con];
//     return coord2;
// }

// double[] FindCoords3(double[] LineData1, double[] LineData3)
// {
//     double[] coord3 = new double[2];
//     coord3[X3] = (LineData3[con] - LineData1[con]) / (LineData1[coef] - LineData3[coef]);
//     coord3[Y3] = LineData1[coef] * coord3[X3] + LineData1[con];
//     return coord3;
// }

bool IntersectLines(double[] LineData1, double[] LineData2, double[] LineData3)
{
    if (!(LineData1[coef] == LineData2[coef] && LineData1[coef] == LineData3[coef]))
    {
        if (!(LineData1[con] == LineData2[con] && LineData1[con] == LineData3[con]))
        {
            Console.WriteLine("Прямые пересекаются");
            return true;
        }
        else
        {
            Console.WriteLine("Прямые не пересекаются");
            return false;
        }
    }
    return true;
}