// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30


int Read(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int m, int n)
{
    int sum = 0;
    if (n == m)
    {
        return n;
    }
    else if (n > m)
    {
        sum = n + Sum(m, n - 1);
        return sum;
    }
    else return -1;
}

int m = Read("Введите число M: ");
int n = Read("Введите число N: ");

if (n > m) Console.Write(Sum(m, n));
if (n < m) Console.Write(Sum(n, m));
