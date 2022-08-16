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

Random rand = new Random();

double number = rand.Next(1,10) + rand.NextDouble();
