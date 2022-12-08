// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [m,n];
for(int i = 0; i < m; i++)
{
for(int j = 0; j < n; j++)
{
matrix[i,j] = new Random().Next(0,11);
Console.Write(matrix[i,j] + " ");
}
Console.WriteLine();
}

Console.Write("Введите строку: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int column = Convert.ToInt32(Console.ReadLine());
if( line < m && column < n )
    {
       
        Console.WriteLine(matrix[line,column]);
    }
else
    {
        Console.WriteLine("такого числа в массиве нет");
    }