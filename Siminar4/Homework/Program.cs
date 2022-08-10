/*
//Task 25 Напишите циклб который принимает на вход числа А и В и возводит число А в степень В. 
int Raise(int num1, int num2)
{
int count = 0;
int result = num1;
    while(count < (num2-1))
    {
        result=result*num1;
        count++;
        Console.Write($"{result}  ");
    }
    return result;
}

Console.WriteLine("Please input your first digit:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input your second digit:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Result = Raise(num1,num2);

Console.WriteLine($"Raise digit {num1} by digit {num2} is {Result}");


//Task 27 Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

int NumOfDigits(int num1)
{
    int count = 0;

    while(num1!=0)
    {
        num1/=10; 
        count++;
    }
    return count;
}

int Sum (int num1,int num2)
{
    int count = 1;
    int sum = 0;
    while(count<=num2)
    {
        int num3 = num1 % 10;
        int lastDigit = num3;
        int num4 = num1 /10;
        sum = sum + lastDigit;
        if (num4<num1) num1 = num4;   
        count++;
    }
    return sum;
}

Console.Write("Please iput your digit: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
int num2 = NumOfDigits(Num1);
int Result = Sum(Num1,num2);
Console.WriteLine($"Sum of digits for your number {Num1} is {Result} .");
*/

// Task 29 Напишите программу которая задает массив из 8 элементов и выводит их на экран.

Console.Write("Please input size number of your array:  ");
int N = Convert.ToInt32(Console.ReadLine());
int[] myArray= new int[N];
Console.WriteLine("Please input digits of your array one by one and press Enter after each digit!");
for(int i=0; i<N; i++)
{
    myArray[i]= Convert.ToInt32(Console.ReadLine());
}
Console.Clear();
Console.Write(" Your array is [");
for (int i= 0; i<N; i++)
{
    Console.Write("{0},", myArray[i]);
}
Console.Write("]");