// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Задайте первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Задайте второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write(Print(num2));

string Print(int num_max)
{
    string s = "";
    if (num_max == num1 - 1) return s;
    return (Print(num_max - 1) + num_max + " ").ToString();
}
