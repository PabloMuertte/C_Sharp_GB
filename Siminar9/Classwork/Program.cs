// Task 1 Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int n)
{

    if (n!=1) ShowNums(n-1);

    Console.Write(n + " ");
}

ShowNums(5);
/// 1 2 3 4 5

void ShowNums(int n)
{
    if (n >= 1)
    {
        Console.Write(n + " ");
        ShowNums(n-1);
    } 
}

ShowNums(5);

//5 4 3 2 1


// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumOfDigits (int n)
{
    if (n != 0) return n % 10 + SumOfDigits(n / 10);
    return 0;
}


int n = 365;
int Sum = SumOfDigits(n);
Console.Write(Sum);

*/


// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
/*

void ShowNums(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m + " ");
        if (m < n) ShowNums(m+1,n);
    }      
    if (m > n)
    {
        Console.Write( n + " ");
        if (m>n) ShowNums(m,n+1);       
    }  
}

Console.Write("Input your M number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your N number: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNums(M,N);
*/

// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.


int NumGrade (int A, int B)
{
    if (B!=0) return A* NumGrade(A,B-1);
    return 1;   
}

Console.Write("Input your A number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your B number: ");
int B = Convert.ToInt32(Console.ReadLine());
int C = NumGrade(A,B);
Console.WriteLine(C);
