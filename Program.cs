﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*Console.WriteLine("Задача:найти max , min");
Console.WriteLine("Введите 1-ое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2-ое число");
int b = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

if (a > b)
max = a;
else if (b > max)
max = b;
if (a < b)
min = a;
else if (b < a)
min = b;
Console.WriteLine("max {0} . min {1}" , max , min);*/

// _______________________________________________________________________________________

// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

/*Console.WriteLine("Задача:найти max , min");
Console.WriteLine("Введите 1-ое число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2-ое число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3-ое число");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

if (num >= num2 && min >= num3)
max = num;
else if (num2 >= num && num2 >= num3)
max = num2;
else if (num3 >= num && num3 >= num2)
max = num3;

if (num <= num2 && num <= num3)
min = num;
else if (num2 <= num && num2 <= num3)
min = num2;
else if (num3 <= num && num3 <= num2)
min = num3;

Console.WriteLine("max {0} . min {1}" , max , min);*/

//______________________________________________________________________________________

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

/*Console.WriteLine("Введите число");

int num = Convert.ToInt32(Console.ReadLine());

if (num %2 == 0)
Console.WriteLine("Число-четное");

else 
Console.WriteLine("Число-не четное");*/

//_______________________________________________________________________________________

/* Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

/*Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(num > 1)
{
while(evenNumber <= num)
{
Console.Write(evenNumber + " ");
evenNumber = evenNumber + 2;
}
} */