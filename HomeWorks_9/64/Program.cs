// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
void ShowNaturalNumbers(int number)
{
    Console.Write(number + " ");
    if (number > 1) ShowNaturalNumbers(number - 1); 
}
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNaturalNumbers(n);