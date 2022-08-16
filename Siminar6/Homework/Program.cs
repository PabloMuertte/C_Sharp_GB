// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*

Console.Write("введите значение b1: "); 
double b1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("введите число k1: "); 
double k1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("введите значение b2: "); 
double b2 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("введите число k2: "); 
double k2 = Convert.ToDouble(Console.ReadLine()); 
 
double x = (b2 - b1)/(k1 - k2); 
double y = k1*((b2-b1)/(k1-k2))+b1; 
 
Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
*/
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

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

int positiveDigit (int [] array)
{
    int sum = 0;
    for (int i=0; i < array.Length; i++)
        if(array[i]>0) sum ++;
    return sum;
}

Console.Write("Input quantity of your digits:  ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(size);
Console.Clear();
Console.WriteLine("This is digits which you input: ");
ShowArray(array);
int result = positiveDigit(array);
Console.WriteLine($"Quantity of digits above zero is [{result}]");