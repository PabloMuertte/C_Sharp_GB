
// Pадача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 5, 6, 7, 8""
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

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int Sum (int m,int n)
{
    if (m!=n) return m + Sum(m+1,n);
    return 0;
}

Console.Write("Input your M number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your N number: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Console.WriteLine(sum = Sum(M,N)+N);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n
// m = 3, n = 2 -> A(m,n) = 29
// m = 2, n = 3 -> A(m,n) = 9
/*
int ack( int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
        {
            return ack(m - 1, 1);
        }
    else if ((m > 0) && (n > 0))
        {
            return ack(m - 1, ack(m, n - 1));
        } 
    else return n + 1;
}

Console.Write("Input your M number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your N number: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your result is {ack(M, N)}");
*/


