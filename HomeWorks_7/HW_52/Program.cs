// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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
    Console.WriteLine();
double sum = 0;
double num = 0;
for(int j = 0 ; j < n; j++)
    {
        for(int i = 0 ; i < m; i++)
            {
                sum = sum + matrix[i,j];
               
            }
            num = sum/m;
                Console.Write(Math.Round(num*10)/10 + "|");
            sum = 0;
            num = 0;

    }