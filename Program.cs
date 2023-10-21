// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Task 64
// Задайте значение N. Напишите программу, которая 
//выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start)
{
    if(start == 1)
    {
        return start.ToString();
    }

    return start + " " + PrintNumbers(start - 1); 
}

System.Console.WriteLine(PrintNumbers(num));