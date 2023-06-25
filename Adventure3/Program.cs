﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int m = InputNumbers("Введите М:   ");
int n = InputNumbers("Введите N:  ");

A(m, n);

int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(m, n);
}

System.Console.WriteLine(A(m, n));




int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

