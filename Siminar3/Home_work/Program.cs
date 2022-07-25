// Home Work
//Task 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Palindrom (int num)
{
    int first = num/10000;
    int last = num % 10;
    int second = (num/1000)%10;
    int prelast = (num % 100)/10;
    if (first ==last && second==prelast) return true;
    else return false;
}
Console.WriteLine();
Console.WriteLine("Hello, this program can help you to check is your five digit number Palindrom!");
Console.WriteLine();
Console.Write ("Please insert your five digit number: ");
int num =Convert.ToInt32(Console.ReadLine());
Console.Clear();
bool result = Palindrom(num);
if (result == true) Console.WriteLine($"Your number {num} is Palindrom!");
if (result == false) Console.WriteLine($"Sorry but your number {num} is not a Palindrom!");
Console.WriteLine();
Console.WriteLine("Thank you!");

//Task 2 Напишите программу, которая принимает на вход координаты двух точек и находит растояние между ними в 3D пространстве.

double Distance(double x_1, double x_2, double z_1, double z_2, double y_1, double y_2)
{
    double distance = Math.Sqrt((x_1-x_2)*(x_1-x_2)+(y_1-y_2)*(y_1-y_2)+(z_1-z_2)*(z_1-z_2));
    return distance;
}

Console.Write("Please insert X Coordinate of point A: ");
int x_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please insert Y Coordinate of point A: ");
int y_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please insert Z Coordinate of point A: ");
int z_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please insert X Coordinate of point B: ");
int x_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please insert Y Coordinate of point B: ");
int y_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please insert Z Coordinate of point B: ");
int z_2 = Convert.ToInt32(Console.ReadLine());

double AB = Distance(x_1,x_2,z_1,z_2,y_1,y_2);

Console.WriteLine($"Distance between point A and B {AB}");

// Task 3 Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.

void Cube (int n)
{
    int current = 1;
    while(current<=n)
    {
        Console.Write(current*current*current+"  ");
        current++;
    }
}
Console.WriteLine();
Console.WriteLine("Hello, this program can help you find all Cube numbers of your number!");
Console.WriteLine();
Console.Write("Input your number for (N): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Clear();
Console.WriteLine();
Console.Write($"Your Cube numbers from 1 to {n}: ");
Cube(n);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Thank you!");
Console.WriteLine();
*/


