// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Результат функции Аккермана: {GetFuncAk(num1, num2)}");

int GetFuncAk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return GetFuncAk(m - 1, 1);
    else return GetFuncAk(m - 1, GetFuncAk(m, n - 1));
}
