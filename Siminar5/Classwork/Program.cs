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

int [] CreateArray(int size)
{
    int [] newArray = new int [size];

    for(int i=0; i < size; i++)
    {
        Console.Write($"{i+1} element of {size}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(int [] Array)
{
    for(int i = 0; i < Array.Length; i++)
        Console.Write(Array[i] + "  ");
    Console.WriteLine();
}

int SumOfPositive (int [] array)
{
    int sum = 0;
    for (int i=0; i < array.Length; i++)
        if(array[i]) sum += array[i];
    return sum;
}

Console.Write("Input size of array:  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element:  ");
int max = Convert.ToInt32(Console.ReadLine());


//int [] array = CreateArray(5);
int [] array = CreateRandomArray(size,min,max);
ShowArray(array);

//Console.WriteLine("Sum of positive elements is "+ SumOfPositive(array));


// task 2 Создать массив с отрицательными и положительными числами и поменять отрицательный знак на положительный и наоброт.
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

void invertArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]= array[i] * -1}, " );
    }
}

Console.Write("Input size of array:  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element:  ");
int max = Convert.ToInt32(Console.ReadLine());


int [] array = CreateRandomArray(size,min,max);
ShowArray(array);
Console.WriteLine();
invertArray(array);
*/

//Task 3 создать массив и найти в нем заданное пользователем число, вывсти да/ нет о его наличии.
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

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
    Console.WriteLine();
}

bool findDigit (int[]array, int X)
{
    for(int i = 0; i < array.Length; i++)
    if (array[i] == X) return true;

    return false;    
}

Console.Write("Input size of array:  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element:  ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("input your digit which you want to find in array:  ");
int X = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray(size,min,max);
ShowArray(array);
Console.WriteLine();
bool find = findDigit(array, X);
Console.WriteLine(find);
*/


// Задайте одномерный массив из 12 случайных чисел. Найдите кол-во элементов массива, значение которых лежат в отрезке [10,99].
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

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
    Console.WriteLine();
}

int QuantitySearchdigits (int[]array)
{
    int qsearchdigits = 0;
        for (int i=0; i < array.Length; i++)
            if(array[i] > 9 && array[i] <100) qsearchdigits++;
    return qsearchdigits;
}
Console.Write("Input size of array:  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element:  ");
int max = Convert.ToInt32(Console.ReadLine());


int [] array = CreateRandomArray(size,min,max);
ShowArray(array);
Console.WriteLine();
int SearchDiaposon = QuantitySearchdigits(array);
Console.Write(SearchDiaposon);

*/

//Найдите произведение пар чисел водномерном массиве, Парой считаем первое и последнее, второе и предпоследнее число и т.д. 
// Результат запишите в новом массиве.

int [] CreateRandomArray(int size,int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i=0; i< size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
    Console.WriteLine();
}

int SumArray (int [] array)
{
    int sum = 0;
    int num1 = 0;
    int num2 = 0;

    for (int i = 0; i< array.Length/2; i++)
    {
        num1 = array[i];
        num2 = array[array.Length-1-i];
        sum = num1 + num2;
        Console.Write($"{sum}"+" ");
    }
    return sum;
}

int arrayLenght(int [] array)
{
    int NewSize = array.Length/2;
    return NewSize;
}


int [] newArray (int newSize,int sum)
{
    int[] result = new int[newSize];
    for (int i = 0; i < newSize; i++)
        result[i] = sum;

    
return result;
}

Console.Write("Input even number size of array:  ");
int size = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input min possible value of element:  ");
int min = 1;
//Console.Write("Input max possible value of element:  ");
int max = 100;


int [] array = CreateRandomArray(size,min,max);
ShowArray(array);
Console.WriteLine();
int sum = SumArray(array);
Console.WriteLine();
int newSize = arrayLenght(array);
int [] Array1 = newArray(newSize,sum);
ShowArray(Array1);

