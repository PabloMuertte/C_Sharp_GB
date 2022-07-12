
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

*/



int thirdDigit(int num)
{
    if (num<100)Console.WriteLine("There is no third digit!");
    if (num>100 && num<1000) num = num % 10;  
    if (num > 1000 && num < 99999) num = num/100 % 10;
    if (num > 99999) Console.WriteLine("System Error");
    int num1 = num;
    return num1;
}

Console.Write("Input your number   ");
int num = Convert.ToInt32(Console.ReadLine());
int result = thirdDigit(num);

Console.WriteLine(result);

