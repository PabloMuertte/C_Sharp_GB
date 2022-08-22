
// Task 1
//Создание двумерного массива через рандом.
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

Console.Write("Input number of rows: ");
int Rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int Columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
int MinValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue: ");
int MaxValue = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int [,] array = createRandom2dArray(Rows,Columns,MinValue,MaxValue);
Show2dArray(array);
*/





// Task 2
//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aij = i+j. 
//Выведите полученный массив на экран.
/*
int [,] createRandom2dArray(int rows, int columns,int minValue, int maxValue)
{
    int [,] newArray = new int[rows,columns];

    for( int i = 0; i < rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            newArray[i,j] = i+j;
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

Console.Write("Input number of rows: ");
int Rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int Columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
int MinValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue: ");
int MaxValue = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int [,] array = createRandom2dArray(Rows,Columns,MinValue,MaxValue);
Show2dArray(array);
*/

// Task 3
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
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

int [,] Search (int [,] array)
{
    int [,] newArray1 = new int [0,0];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0) array[i,j] = array [i,j] * array [i,j];
            
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine ();
    }
    return newArray1;
}

Console.Write("Input number of rows: ");
int Rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int Columns = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input minValue: ");
int MinValue =1;// Convert.ToInt32(Console.ReadLine());
//Console.Write("Input maxValue: ");
int MaxValue = 10;// Convert.ToInt32(Console.ReadLine());
Console.Clear();
int [,] Array = createRandom2dArray(Rows,Columns,MinValue,MaxValue);
Show2dArray(Array);
Console.WriteLine();
int [,] array1 = Search (Array);
Show2dArray(array1);
*/


// Task 4
// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали с индексами (0,0); (1;1) и т.д. 
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

int Sum (int [,] array)
{
    int A = 0;
    for(int j = 0, k = 0; k < array.GetLength(0); j++, k++)
        A += array[k,j];           
        
    return A;
}

Console.Write("Input number of rows: ");
int Rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int Columns = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input minValue: ");
int MinValue =1;// Convert.ToInt32(Console.ReadLine());
//Console.Write("Input maxValue: ");
int MaxValue = 10;// Convert.ToInt32(Console.ReadLine());
Console.Clear();
int [,] Array = createRandom2dArray(Rows,Columns,MinValue,MaxValue);
Show2dArray(Array);
Console.WriteLine ();

int sum = Sum(Array);

Console.WriteLine(sum);