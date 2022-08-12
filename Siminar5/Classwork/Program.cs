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

bool findDigit (int Y, int X)
{
    if (Y == X) return true;
    else return false;
}

int Compare (int [] array)
{
    int compare = 0;
    for(int i = 0; i < array.Length; i++)
    {
        compare = compare + array[i];
    }
    return compare;
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
int Y = Compare(array);
bool find = findDigit(Y,X);
Console.WriteLine(find);

