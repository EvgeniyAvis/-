﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int a;
Console.WriteLine("Введите число ");
a = Convert.ToInt32(Console.ReadLine());
if (a%2==0)
{
    Console.WriteLine($"Число {a} является четным");
}
else
{
    Console.WriteLine($"Число {a} является нечетным");
}

