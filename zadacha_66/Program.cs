// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Задайте первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Задайте второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел в интервале ({num1},{num2}) равна: {PrintSum(num2)}");

int PrintSum(int num_max)
{
    int s = 0;
    if (num_max == num1 - 1) return s;
    return (PrintSum(num_max - 1) + num_max);
}

