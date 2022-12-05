/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Например:
a = 5 b = 7 -> max = 7, a = 2 b = 10 -> max = 10, a = -9 b = -3 -> max = -3 */



Console.WriteLine("Enter numberA:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter numberB:");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("numberA");
}

if (numberA < numberB)
{
    Console.WriteLine("numberB");
}

if (numberA == numberB)
{
    Console.WriteLine("Числа равны");
}

