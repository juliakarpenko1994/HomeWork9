/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке
 от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1)
{
    System.Console.WriteLine("Введено не натуральное число");
}

int NaturalNumber(int num)
{
    if (num == 1) return num;
    else
    {
        System.Console.Write($"{NaturalNumber(num - 1)}, ");
    }
    return num;
}
NaturalNumber(n);*/



/*Задача 66: Задайте значе5ния M и N. Напишите программу, которая найдёт сумму натуральных элементов
 в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

System.Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());


if (n < 1 && m < 1)
{
    System.Console.WriteLine("Введено не натуральное число");
}
int SumNaturalNum(int m, int n)
{
    int sum = m;
    if (m == n) return 0;
    else
    {
        m++;
        sum = m + SumNaturalNum(m, n);
        return sum;
    }
}
System.Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} -> {SumNaturalNum(m-1, n)}");*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два
 неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

System.Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return (AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)));
    }
}
System.Console.WriteLine($"{AkkermanFunction(m,n)}");