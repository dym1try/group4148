// //Задача №11
// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа. 
int num = new Random().Next(100,1000);
int fisNum = num/100;
int lasNum = num%10;
int newNum = fisNum*10 + lasNum;
Console.WriteLine(num);
Console.WriteLine(newNum);