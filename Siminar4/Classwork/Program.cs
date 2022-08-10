/*

int NumOfDigits(int num)
{
    int count = 0;

    while(num!=0)
    {
        num/=10; //num=num/10
        count++;
    }
    return count;
}

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = NumOfDigits(number);

Console.WriteLine($"Number of digits {number} is {result}");


// Task 2 программа принимает число А и выводит сумму чисел от 1 до А.

int SumOfDigits(int num)
{
    int sum = 0;
    int count = 0;
    while(count < num)
    {
        sum = count+(sum+1);
        count++;
    }
    return sum;
}
Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumOfDigits(number);

Console.WriteLine($"Sum of digits from 1 to {number} is {result}");


// Task 3 Программа принимает число N, и выдает произведение чисел этого числа, кратных трем.
int MultplyOfDigits(int num)
{
    int multiply = 1;
    int count = 0;
    while(count<num)
    {
        count=count+3;
        multiply=multiply*count;
        Console.Write($"{multiply}  ");
    }
    return multiply;
}
Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = MultplyOfDigits(number);

Console.WriteLine($"Multiply of digits from 1 to {number} and which multiple by 3 is {result}");
*/
// Draft for random Array

int [] CreateRandomArray(int size,int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i=0; i< size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }

    return newArray;
}

void ShowArray(int [] Array)
{
    for(int i = 0; i < Array.Length; i++)
        Console.Write(Array[i] + "  ");
    Console.WriteLine();
}

int[] binaryArray = CreateRandomArray(5,100,999);
ShowArray(binaryArray);