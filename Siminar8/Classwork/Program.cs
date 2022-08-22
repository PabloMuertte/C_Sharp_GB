// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.


//Task 1 Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

int [,] Change (int [,] array)
{
    int temp = 0;
    int temp1 = 0;
    int lenght = array.GetLength(1);     
    for (int i = 0; i < array.GetLength(1) ; i++)
        {
            temp = array[0,i];
            temp1 = array[lenght-1,i];
            array[0,i] = temp1;
            array[lenght-1,i] = temp;
        }
        return array;
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

int [,] newArray = Change(Array);
Show2dArray(newArray);
*/


// Task 2 Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

int [,] RowsToColmns (int [,] array)
{
    for (int i = 1;  i < array.GetLength(1); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            int temp = array[j,i];
            int temp1 = array[i,j];
            if (j<i) array[j,i] = temp1;
            if (j<i) array[i,j] = temp;

        }   
    }
    return array;             
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

int [,] newArray = RowsToColmns(Array);

Show2dArray(newArray);
*/


// Task 3 Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

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

int [,] CutArray (int [,] array)
{
    int iMin = 0, jMin = 0;
    int [,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]< array[iMin,jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    for (int i = 0, m = 0; i<array.GetLength(0); i++, m++)
    {
        if(i==iMin) i++;

        for(int j=0,n = 0; j<array.GetLength(1); j++, n++ )
        {
            if (j==jMin) j++;

            newArray[m,n] = array[i,j];
        }
    }


    return newArray;   
    
}
        

Console.Write("Input number of rows: ");
int Rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int Columns = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input minValue: ");
int MinValue =1;// Convert.ToInt32(Console.ReadLine());
//Console.Write("Input maxValue: ");
int MaxValue = 5;// Convert.ToInt32(Console.ReadLine());
Console.Clear();
int [,] Array = createRandom2dArray(Rows,Columns,MinValue,MaxValue);
Show2dArray(Array);
Console.WriteLine ();

int [,] NewArray = CutArray(Array);

Show2dArray(NewArray);
