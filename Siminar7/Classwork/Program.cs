
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

// Task 3
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
// Task 4
// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали с индексами (0,0); (1;1) и т.д.


// Task 2
//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aij = i+j. 
//Выведите полученный массив на экран.

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

