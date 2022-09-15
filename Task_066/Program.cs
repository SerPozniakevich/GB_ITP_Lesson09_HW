//Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежудке от M до N. 

Console.Clear();


System.Console.WriteLine("Enter M: ");
int start = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter N: ");
int end = int.Parse(Console.ReadLine());

System.Console.WriteLine($"M = {start}; N = {end}. -> {AmountLineNumbers(start, end)}");


int AmountLineNumbers(int start, int end)
{
return (end == start) ? end: end + AmountLineNumbers (start, end - 1);
}
