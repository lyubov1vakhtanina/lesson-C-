// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
// System.Console.WriteLine("Большее число: " + a + ", меньшее число: " + b);
// else System.Console.WriteLine($"Большее число: {a}, меньшее число: {b}");

//Задача2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
 

// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (max < b) max = b;
// if (max < c) max = c;

// System.Console.WriteLine("Максимальное из этих чисел = »"+ max); 


// Задача3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
 
// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 0)
// System.Console.WriteLine("Число: " + a + " четное");
// else System.Console.WriteLine($"Число: {a} нечетное");

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
 
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=n;i++)
{
if (i % 2 == 0)
System.Console.Write(i + ", ");
}