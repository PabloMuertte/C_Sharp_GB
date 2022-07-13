
/*
// Task 10 Напишите программу, которая принимает трехзначное число и на выходе показывает
// вторую цифру этого числаю
//Program with random three-digit number;

int MiddleDigit(int num)
{
    int first = num / 10;
    int middle = first % 10;
    
    
    int target = middle;
    return target;
}
int num = new Random().Next(100,1000);
int number = MiddleDigit(num);

Console.WriteLine($"Your middle digit {number} of {num}!");

//Program with user three-digit number input;
int MiddleDigit(int num)
{
    int first = num / 10;
    int middle = first % 10;
    
    
    int target = middle;
    return target;
}
Console.Write("Please input your three-digit number  :");
int num = Convert.ToInt32(Console.ReadLine());
int number = MiddleDigit(num);

Console.WriteLine($"Your middle digit {number} of {num}!");




// Task 13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int thirdDigit(int num)
{
    if (num<100)Console.Write("There is no third digit in number  ");
    if (num>100 && num<1000) num = num % 10;
    if (num > 1000 && num < 9999) num = num/10 % 10;
    if (num > 1000 && num < 99999) num = num/100 % 10;
    if (num > 99999) Console.Write("System Error by number  ");
    int num1 = num;
    return num1;
}

Console.Write("Input your number   ");
int num = Convert.ToInt32(Console.ReadLine());
int result = thirdDigit(num);

Console.WriteLine(result);


// Task 15 Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет,
// является ли этот день недели выходным.

bool weekends(int num)
{
    if (num > 5 && num < 8) return true;
    else return false;
}
Console.WriteLine();
Console.WriteLine("Hello!");
Console.WriteLine();
Console.Write("Please input your number of the day  ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 7 || num < 1 ) Console.WriteLine("Error//: Your number not the number of the week!");
if (num > 7 || num < 1 ) Console.WriteLine("Error//: Please try another number!");
if (num > 7 || num < 1 )
{
    Environment.Exit(0);
}
bool result = weekends(num);
Console.WriteLine();
if (result == true) Console.WriteLine($"Your day number {num} is Weekend!");
if (result == false) Console.WriteLine($"Your day number {num} is Work day!");
*/