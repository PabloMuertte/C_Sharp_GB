/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

// Задача 54 упорядочение на увеличение, как в примере.
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

int [,] arrange (int [,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++ )
        {
            for(int k = 0; k < array.GetLength(1)-1; k++ )
            {
                if (array[i, k] > array[i, k+1])
                {
                    int temp = array[i, k+1];
                    array[i, k+1] = array[i, k];
                    array[i, k] = temp;
                }
            }
                
            
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

int [,] sortedArray = arrange(Array);
Show2dArray(sortedArray);
*/

// Задача 54 сортировка на увеличение.

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

int [,] arrangeDecrease (int [,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++ )
        {
            for(int k = 0; k < array.GetLength(1)-1; k++ )
            {
                if (array[i, k+1] > array[i, k])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k+1];
                    array[i, k+1] = temp;
                }
            }
                
            
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

int [,] sortedArray = arrangeDecrease(Array);
Show2dArray(sortedArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int [,] NewArray (int [,] array)
{
    int [,] NewSumArray =  new int [array.GetLength(0),1];
        for(int i = 0; i < array.GetLength(0); i++)
    {
        int Sum = 0;
        for(int j = 0; j < array.GetLength(1); j++ )
        {
            
            Sum += array[i,j];
            
        }      
        NewSumArray[i,0] = Sum;
        
    }
    return NewSumArray;
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

int [,] NewSumArray = NewArray(Array);
Console.WriteLine("Array with the sum of the rows: ");
Show2dArray(NewSumArray);


int min = NewSumArray[0,0];
int minrow = 0;
for(int i = 1; i < NewSumArray.GetLength(0); i++)
{
    int temp = NewSumArray[i,0];
    if (min > temp)
    {
        min = temp;
        minrow = i;
    }

}

Console.WriteLine($"Row with minimal sum of elements is {minrow+1} row.");
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int [,] multiplyArray (int [,] array1,int [,] array2)
{
    int [,] NewMultiplyArray = new int[array1.GetLength(0),array1.GetLength(1)];
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            NewMultiplyArray[i,j] = array1[i,j]*array2[i,j];
        }
    }
    return NewMultiplyArray; 
}

Console.Write("Input number of rows: ");
int Rows = 5; //Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int Columns = 5; //Convert.ToInt32(Console.ReadLine());
//Console.Write("Input minValue: ");
int MinValue =1;// Convert.ToInt32(Console.ReadLine());
//Console.Write("Input maxValue: ");
int MaxValue = 10;// Convert.ToInt32(Console.ReadLine());
Console.Clear();
int [,] Array1 = createRandom2dArray(Rows,Columns,MinValue,MaxValue);
Show2dArray(Array1);
Console.WriteLine ();
int [,] Array2 = createRandom2dArray(Rows,Columns,MinValue,MaxValue);
Show2dArray(Array2);
Console.WriteLine ();
int [,] Array3 = multiplyArray(Array1,Array2);
Show2dArray(Array3);
*/

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int [,,] createRandom3dArray (int rows, int columns, int deep)
{
    int [,,] newArray = new int[rows,columns,deep];
    for(int i = 0; i < rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            for(int k=0; k<deep; k++)
            {
                newArray[i,j,k] = new Random().Next(10,99);
            }
            
        }
    }
    return newArray;
}

void Show3dArray(int [,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0,k = 0; j < array.GetLength(1); j++,k++)
        {
        Console.Write($"{array[i,j,k]}({i},{j},{k})"+" ");   
        }   
        Console.WriteLine ();
           
    }   

}

//Console.Write("Input number of rows: ");
int Rows = 2; //Convert.ToInt32(Console.ReadLine());
//Console.Write("Input number of columns: ");
int Columns = 2; //Convert.ToInt32(Console.ReadLine());
//Console.Write("Input minValue: ");
int Deep = 2; //Convert.ToInt32(Console.ReadLine());

Show3dArray(createRandom3dArray(Rows,Columns,Deep));










