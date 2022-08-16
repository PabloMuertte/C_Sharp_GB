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

int [] ReverseArray(int []array)
{
    for (int i=0, j = array.Length-1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j]= temp;
    }
    return array;
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
int [] Array = ReverseArray(array);
ShowArray(Array);
/*
Пример рандомной генерации double переменной
Random rand = new Random();
double number = rand.Next(1,10) + rand.NextDouble();
*/

// TAsk 1 Программа принимает на вход 3 числа и проверяет существует ли треугольник с такой длинной сторон.
//Каждая из сторон меньше суммы двух других.

/*
bool verifyTriangle (int x, int y, int z)
{
    if (x<y+z || y<x+z || z<y+x) return false;
    return true;
}

Console.Write("Input first digit: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second digit: ");
int Y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third digit: ");
int Z = Convert.ToInt32(Console.ReadLine());
Console.Clear();
bool Triangle = verifyTriangle(X,Y,Z);
Console.WriteLine(Triangle);
*/


// Task2 Написать программу которая будет переводить из десятично системы в двоичную.
/*
string Doubled (int X)
{
    string result = string.Empty;
    while (X!=0)
    {
        int temp = X % 2;
        X= X/2;
        result = temp + result;
    }    
    return result;
}
 
Console.Write("Input your dec digit: ");
int X = Convert.ToInt32(Console.ReadLine());

string Result = Doubled(X);
Console.WriteLine(Result);
*/

// Task 3 Программа выдает N Чисел фибоначи, первые два числа задаютс аргументом.

string Fibonachi (int size,int num1, int num2)
{
    string result = string.Empty;
    for (int i = 0; i< size; i++)
        {
            int result1 = num1 + num2;
            num1 = num2; num2 = result1;
            result = result +" "+ result1;
        }
    return result;
}

Console.Write("Input your size of fibonachi numbers: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your first digit: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your second digit: ");
int Y = Convert.ToInt32(Console.ReadLine());

string Result = Fibonachi(size,X,Y);
Console.WriteLine(Result);


