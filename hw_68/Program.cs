// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m, n) = 9

int Read(string message)
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}

int Akk(int m, int n)
{
  if (m == 0) return n += 1;
  else if (m > 0 && n == 0) return Akk(m - 1, 1);
  else if (m > 0 && n > 0) return Akk(m - 1, Akk(m, n - 1));
  return Akk(m, n);
}


int m = Read("Введите неотрицательное число M: ");
int n = Read("Введите неотрицательное число N: ");

if (m < 0 || n < 0)
{
  Console.WriteLine("Одно из чисел отрицательное!");
}
else Console.WriteLine($"A(m, n) = {Akk(m, n)}") ; 