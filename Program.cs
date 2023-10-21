// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Task 64
// Задайте значение N. Напишите программу, которая 
//выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int start)
// {
//     if(start == 1)
//     {
//         return start.ToString();
//     }

//     return start + " " + PrintNumbers(start - 1); 
// }

// System.Console.WriteLine(PrintNumbers(num));

// Task 66
//Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Enter a number M: ");
// int numM = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter a number N: ");
// int numN = Convert.ToInt32(Console.ReadLine());

// int sum = 0;

// int SumOfRange(int num1, int num2)
// {
//     sum += num1;
//     if(num1 == num2)
//     {
//         return sum;
//     }
//     else
//     {
//         return SumOfRange(num1 + 1, num2);
//     }
// }

// System.Console.WriteLine(SumOfRange(numM, numN));

// Task 68

// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Enter a number m: ");
int numM = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number n: ");
int numN = Convert.ToInt32(Console.ReadLine());

int Ack(int m, int n)
{
    if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Ack(m - 1, 1);
    else
      return Ack(m - 1, Ack(m, n - 1));

}

System.Console.WriteLine(Ack(numM,numN));