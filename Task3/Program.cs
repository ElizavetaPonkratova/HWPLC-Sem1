﻿/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Например: 4 -> да -3 -> нет 7 -> нет*/

Console.WriteLine("Enter number:");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 1)
{
      Console.WriteLine(num + " NO");
}
else
{
       Console.WriteLine(num + " YES");
}