
/*
// Task 1 

void FindBiggerDigitVoid(int num)
{
    int ed = num % 10;
    int dec = num / 10;
    int max;

    if (ed>dec) max = ed;
    else max = dec;

    Console.WriteLine(max);
}

//Method find bigger digit from dec number
int FindBiggerDigit(int num)
{
    int ed = num % 10;
    int dec = num / 10;
    int max;

    if (ed>dec) max = ed;
    else max = dec;

    return max;
}

int number = new Random().Next(10,100);
int digit = FindBiggerDigit(number);

Console.WriteLine($"Bigger digit of {number} is {digit}");


// Task 2

bool isfrequentcy(int n1, int n2)
{
    if(n1 % n2 == 0) return true;
    else return false;
}

Console.Write("Input first number:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool kratno = isfrequentcy(num1, num2);

Console.WriteLine(kratno);



// Task 3 

int numWithoutMiddleDigit(int num)
{
    int last = num % 10;
    int first = num / 100;
    
    Console.WriteLine("First digit:  " + first);
    Console.WriteLine("Last digit:  " + last);
    int target = first*10 + last;
    return target;
}

int num = new Random().Next(100,999);
int number = numWithoutMiddleDigit(num);

Console.WriteLine($"Your new number {number} of {num}!");



//Task 5 Написать программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

bool frequentNumber(int num)
{
    if (num % 7 == 0 && num % 23 == 0) return true;
    else return false;
}
int num = new Random().Next(10,1000);
bool kratno = frequentNumber(num);


Console.WriteLine(num);

Console.WriteLine(kratno);
*/
// Task 6 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool Square(int num1,int num2)
{
    if (num1 == num2*num2 || num2 == num1 * num1) return true;
    else return false;
}

int num1 = new Random().Next(1,10);;
int num2 = new Random().Next(1,10);;
bool result = Square(num1, num2);
Console.WriteLine(num1);
Console.WriteLine(num2);
Console.WriteLine(result);




