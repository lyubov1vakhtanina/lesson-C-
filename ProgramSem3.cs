﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// int num, r, sum=0,t;
// Console.Write("Введите пятизначное число: ");
// num = Convert.ToInt32(Console.ReadLine());
// if(num>9999 && num<100000)
// {
// for(t=num;num!=0;num=num/10)
// {
// r=num % 10;
// sum=sum*10+r;
// }
// if(t==sum)
// Console.Write($"{t} является палиндромом.");
// else
// Console.Write($"{t} не является палиндромом.");
// } else
// Console.Write("Введите пятизначное число! ");


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int InputN(string message)
// {
// System.Console.Write($"{message}> ");
// int value;
// if (int.TryParse(Console.ReadLine(), out value))
// {
// return value;
// }
// System.Console.WriteLine("Вы ввели не число");
// Environment.Exit(1);
// return 0;

// }

// int x1 = InputN ("Введите координату X точки A");
// int y1 = InputN ("Введите координату Y точки A");
// int z1 = InputN ("ведите координату Z точки A");
// int x2 = InputN ("Введите координату X точки B");
// int y2 = InputN ("Введите координату Y точки B");
// int z2 = InputN ("Введите координату Z точки B");

// double dis(int x1, int y1, int z1, int x2, int y2, int z2)
// {
// int deltax = x2 - x1;
// int deltay = y2 - y1;
// int deltaz = z2 - z1;
// return Math.Sqrt(deltax*deltax+deltay*deltay+deltaz*deltaz);
// }
// System.Console.Write($"Растояние между точками A и B равно {dis(x1, y1, z1, x2, y2, z2):F2} ");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов:\n");
for (int i=1;i<=n;i++)
{
int k = i*i*i;
Console.Write($"{k}, ");
}