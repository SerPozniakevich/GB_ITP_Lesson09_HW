//Задача 64: Задайте значения M и N. Напишите программу,
//которая выведет все натуральные числа в промежудке от M до N. 

System.Console.WriteLine("Enter M: ");
int m = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter N: ");
int n = int.Parse(Console.ReadLine());

System.Console.WriteLine($"M = {m}; N = {n}. -> {PrintNumbers(m,n)}");

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return $"{start} "+  PrintNumbers(start + 1, end);
}