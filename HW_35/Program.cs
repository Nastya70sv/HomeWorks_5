// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int[] FillArray(int size)
{
int[] arr = new int[size];
for(int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(10,1000);
}
return arr;
}
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.WriteLine("Массив : " +string.Join(", ", array));
int check = 0;

for(int i = 0; i < array.Length; i++)
{
 if (array[i]>10 && array[i]< 99 )
 {
    check ++;
 }
}
if (check > 0)
{
    Console.Write($"Количество элементов лежащих в отрезке [10,99]: {check} ");
    }
else 
{
    Console.Write("Элементов нет");
}
