// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int Read(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


void namb(int n)
{
    if (n <= 0)
    {
        return;
    }
    else
    {
        Console.Write(n + " ");
        namb(n - 1);
    }
}

int n = Read("Введите число N: ");
namb(n);