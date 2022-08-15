// Task 34 Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Так же я сам дописал от себя код чтобы дополнительно выводились положительные числа.
/*
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

}

int quantityOfEvenNumber(int [] array)
{
    int qEven = 0;
        for (int i=0; i < array.Length; i++)
            if(array[i]%2 == 0) qEven++;
    return qEven;
}

void PrintEvenNumber(int [] array)
{
    for (int i=0; i < array.Length; i++)
        if(array[i]%2 == 0) 
        Console.Write(array[i] + " ");
    
}

Console.Write("Input size of array:  ");
int size = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input min possible value of element:  ");
int min = 100; //Convert.ToInt32(Console.ReadLine());
//Console.Write("Input max possible value of element:  ");
int max = 999; //Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray(size,min,max);



Console.Write($"Quantity of even numbers in your array [");
ShowArray(array);
Console.Write($"] is {quantityOfEvenNumber(array)} and it is digit [ ");
PrintEvenNumber(array);
Console.Write("]");


// Task 36 Задайте одномерный массив, заполненый случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.

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

}

int sumOfnotEvennumbersofarray(int[] array)
{
    int sum = 0;
    for(int i = 0; i< array.Length; i++)
    {
        
        if (array[i]%2==0);
        else 
        {
            sum = sum + array[i];
            Console.Write($"{array[i]}"+" ");
        }
    }
    return sum;
}

Console.Write("Input size of array:  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Clear();
//Console.Write("Input min possible value of element:  ");
int min = 100; //Convert.ToInt32(Console.ReadLine());
//Console.Write("Input max possible value of element:  ");
int max = 999; //Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray(size,min,max);
Console.Write($"Your random array of {size} numbers is ");
ShowArray(array);
Console.WriteLine();
Console.WriteLine();
Console.Write($"Your not even numbers is ");
int Sum = sumOfnotEvennumbersofarray(array);
Console.WriteLine();
Console.WriteLine($"Sum of your not even number {Sum}");

*/

// Task 37 Задайте Массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

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

}

int difference (int [] array)
{
    int max = 0;
    int min = 0;
    int dif = 0;
    for( int i = 0; i< array.Length; i++)
    {
        if(array[i]> max) max = array[i];
        min = array[i];
        dif = max - min;
        
    }
    Console.WriteLine($"min digit ({min})");
    Console.WriteLine($"max digit ({max})");
    return dif;

}

Console.Write("Input size of array:  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Clear();
//Console.Write("Input min possible value of element:  ");
int min = 100; //Convert.ToInt32(Console.ReadLine());
//Console.Write("Input max possible value of element:  ");
int max = 999; //Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray(size,min,max);
Console.Write($"Your random array of {size} numbers is ");
ShowArray(array);
Console.WriteLine();
int dif = difference(array);
Console.WriteLine($"Diffirence between max and min elements of array  is {dif}");