// Task 1 

//Method find bigger digit
int FindBiggerDigit(int num)
{
    int ed = num % 10;
    int dec = num / 10;
    int max;

    if (ed>dec) max = ed;
    else max = dec;

    return max;
}

int number = new Random().Next(10,100);
int digit = FindBiggerDigit(number);

Console.WriteLine($"Bigger digit of {number} is {digit}");
