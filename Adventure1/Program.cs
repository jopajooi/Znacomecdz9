// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int N = InputNumbers("Введите N:   ");

System.Console.WriteLine();
// skobochka1(N);
CreateArray(N);
// skobochka2(N);


int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}


int CreateArray(int k)
{
    int I = 0;
    k = N;
    if (k > 0 && k <= N)
    {
        for (int i = 0; i < N + 2; i++)
        {
            I = i;


            if (I == 0)
            {
                skobochka1(N);
            }
            if (k == N)
            {
                System.Console.Write($"{N + " "}");
            }
            if (I == N + 1)
            {
                skobochka2(N);
            }



            while (k > 1)
            {
                k -= 1;
                System.Console.Write($"{k + "  "}");
            }




        }
    }
    return k;
}



int skobochka1(int s1)
{
    System.Console.Write("[");
    return s1;
}

int skobochka2(int s2)
{
    System.Console.Write("]");
    return s2;
}