//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях(индексах).
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
int sum = 0;

for (int i = 1; i < array.Length; i+=2)
    sum = sum + array[i];

    Console.WriteLine($"всего {array.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");


