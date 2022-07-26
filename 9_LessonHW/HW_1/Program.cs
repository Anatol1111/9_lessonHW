// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void EvenNum(int M, int N)
{
if (N < M) return;
else if (M % 2 == 0) Console.Write($"{M}, ");
else
{
M++;
Console.Write($"{M}, ");
}
EvenNum(M + 2, N);
}

EvenNum(1, 5);
Console.WriteLine();
EvenNum(4, 8);