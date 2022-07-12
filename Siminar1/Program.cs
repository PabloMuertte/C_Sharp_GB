/*
// Task 2 Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
int num1, num2;
Console.WriteLine();
Console.WriteLine("Hello my friend!");
Console.WriteLine();
Console.WriteLine("This programm shows biggest and smallest number!");
Console.WriteLine();
Console.Write("Input first integer number  ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number  ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (num1>num2)
{
    Console.WriteLine("Biggest number  " + num1);
    Console.WriteLine("Smallest number  " + num2);
}
else
{
    Console.WriteLine("Biggest number " + num2);
    Console.WriteLine("Smallest number  " + num1);
}
Console.WriteLine();
Console.WriteLine("Thank you! See you soon!");


//Task 4 Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

int num1, num2, num3, biggest;
Console.WriteLine();
Console.WriteLine("Hello my friend!");
Console.WriteLine();
Console.WriteLine("This programm shows biggest number!");
Console.WriteLine();
Console.Write("Input first integer number  ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number  ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number  ");
num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (num1>num2)
{
    biggest = num1;
}
else
{
    biggest = num2;
}
if (biggest>num3)
{
    Console.WriteLine("Biggest number " + biggest);
}
else 
{
    Console.WriteLine("Biggest number " + num3);
}


// Task 6 Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

int num1;
Console.WriteLine();
Console.WriteLine("Hello my friend!");
Console.WriteLine();
Console.WriteLine("This programm helps to decide does your number even!");
Console.WriteLine();
Console.Write("Please input your number  ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if(num1 % 2 == 0)
{
    Console.WriteLine("Number  " + num1 +"  even!");
}
else
{
    Console.WriteLine("Number  " + num1 + " not even!");
}
Console.WriteLine();
Console.WriteLine("Thank you!");


//Task 8 Напишите программу, которая принимает число (N), а на выходе показывает все четные числа от 1 до N.
Console.WriteLine();
Console.WriteLine("Hello, this program can help you find all even numbers of your number!");
Console.WriteLine();
Console.Write("Input your integer number for (N): ");
int n = Convert.ToInt32(Console.ReadLine());
int current = 1;
Console.WriteLine();
Console.Clear();
Console.Write("Your even numbers: ");
while(current<=n)
{
    if(current % 2 == 0)
    {
        Console.Write(current+", "); 
    }
current++;
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Thank you!");
Console.WriteLine();



// Lesson_2 Introducing in Functions and massives.

int Max (int arg1, int arg2, int arg3 )
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 331;

//int max1 = Max(a1,b1,c1);
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);

int max = Max (Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3));

Console.WriteLine(max);



//Example 2 Working with array


int Max (int arg1, int arg2, int arg3 )
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}
int [] array = {11, 211, 31, 41, 15, 61, 17, 18, 19 };
//array[0] = 12;
//Console.WriteLine(array[0]);
int result = Max(
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8])
);
Console.WriteLine(result);

//Example 3 Find N number of array

int[] array = {1,12,31,4,15,16,17,31};

int n = array.Length;
int find = 31;

int index = 0;

while (index<n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;    
    }
    // index = index + 1;
    index++;
}

// Example 4 

void FillArray(int[]collection)
{
    int length = collection.Lenght;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random() .Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < col)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int [] array = new int [10];
*/