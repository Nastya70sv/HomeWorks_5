// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.WriteLine("Введите размерность массива");
// Console.Write("m = ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("n = ");
// int n = Convert.ToInt32(Console.ReadLine());

// void FillArray(int m, int n)
// {
//     double[,] matrix = new double[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 11) + new Random().NextDouble();
//             Console.Write($"{matrix[i, j]}, ");
//         }
//         Console.WriteLine();
//     }
// }
// FillArray(m, n);

Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [m,n];
for(int i = 0; i < m; i++)
{
for(int j = 0; j < n; j++)
{
matrix[i,j] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
Console.Write(matrix[i,j] + " ");
}
Console.WriteLine();
}
