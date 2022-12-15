// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Решено с помощью рекурсии
int SumBetweenNumsRec(int m, int n)
{
    if (m > n)
        return SumBetweenNumsRec(m - 1, n) + m;
    else if (m < n)
        return SumBetweenNumsRec(m, n - 1) + n;
    else return n;
}
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных чисел между {m} и {n} равна {SumBetweenNumsRec(m, n)}");
