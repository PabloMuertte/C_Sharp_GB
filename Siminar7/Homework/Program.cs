// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
/*
double [,] createRandom2dArray(int rows, int columns,double minValue, double maxValue)
{
    double [,] newArray = new double[rows,columns];

    for( int i = 0; i < rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            //Random rand = new Random();
            //double number = rand.Next(1,10) + rand.NextDouble(); 
            newArray[i,j] = new Random().Next() + new Random().NextDouble(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int Rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int Columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
double MinValue = Convert.ToDouble(Console.ReadLine());
Console.Write("Input maxValue: ");
double MaxValue = Convert.ToDouble(Console.ReadLine());
Console.Clear();

double [,] array = createRandom2dArray(Rows,Columns,MinValue,MaxValue);
Show2dArray(array);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
/*

int [,] createRandom2dArray(int rows, int columns,int minValue, int maxValue)
{
    int [,] newArray = new int[rows,columns];

    for( int i = 0; i < rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine ();
    }
}

int Search (int [,] array,int find, int MinValue, int MaxValue)
{
    int S = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == find) S=1;
            if(find < MinValue || find > MaxValue) S=2;
        }
        
    }
    return S;
}


//Console.Write("Input number of rows: ");
int Rows = 5; //Convert.ToInt32(Console.ReadLine());
//Console.Write("Input number of columns: ");
int Columns = 5; //Convert.ToInt32(Console.ReadLine());
//Console.Write("Input minValue: ");
int MinValue = 1; //Convert.ToInt32(Console.ReadLine());
//Console.Write("Input maxValue: ");
int MaxValue = 20; //Convert.ToInt32(Console.ReadLine());
Console.Write("Input your Digit between 1 and 10: ");
int Find = Convert.ToInt32(Console.ReadLine());

int [,] array = createRandom2dArray(Rows,Columns,MinValue,MaxValue);
Show2dArray(array);
int search = Search(array,Find,MinValue,MaxValue);

if (search==1) Console.WriteLine($"You digit {Find} is in array!");
if (search==0) Console.WriteLine($"You digit {Find} not founded in array!");
if (search==2) Console.WriteLine("Your digit not accepted for this array!");
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine ();
    }
}

int[,] array1 = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, {8, 4, 2, 4 } };

Show2dArray(array1);

Console.WriteLine();
for (int i = 0; i < array1.GetLength(1); i++)
{
    double arithmeticMean = 0;
    for (int j = 0; j < array1.GetLength(0) ; j++)
    {
        arithmeticMean += array1[j, i];
    }
    arithmeticMean = Math.Round(arithmeticMean / array1.GetLength(0), 2);
    Console.WriteLine($"Arithmetic Mean of Column № {i+1} is {arithmeticMean}");
}
