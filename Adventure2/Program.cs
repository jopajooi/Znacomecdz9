// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int m = InputNumbers("Введите М:   ");
int n = InputNumbers("Введите N:  ");



Sum(m, n);

void Sum(int m, int n)
{
    Console.Write(SumCreate(m - 1, n));
}


int SumCreate(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumCreate(m, n);
        return res;
    }
}


int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

