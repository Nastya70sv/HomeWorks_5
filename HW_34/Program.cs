// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillArray(int size)
{
int[] arr = new int[size];
for(int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(100,1000);
}
return arr;
}
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.WriteLine("Массив : " +string.Join(", ", array));
int a = 0;

for(int i = 0; i < array.Length; i++)
{
 if (array[i]%2==0 )
 {
    a ++;
 }
}
if (a > 0)
{
    Console.Write($"Количество четных чисел в массиве: {a} ");
    }
else 
{
    Console.Write("Массив НЕ содержит четных чисел");
}