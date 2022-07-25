// a = Math.Sqrt(b); квадратный корень
//distance = Math.Sqrt(ac*ac+bc*bc)

//Task 1 программа принимающая на вход четверть координатной сетки и выдающая диапазон координат
/*
void ShowDiaposon(int quart)
{
    if(quart >= 1 && quart <=4)
    {
        if(quart == 1) Console.WriteLine("x>0,y>0");
        if(quart == 2) Console.WriteLine("x<0,y>0");
        if(quart == 3) Console.WriteLine("x<0,y<0");
        if(quart == 4) Console.WriteLine("x>0,y<0");
    }
    else Console.WriteLine("Uncorrect input!");
}


void ShowDiaposon(int quart)
{
    while(quart < 1 || quart >4)
    {
        Console.Write("Incorrect input! Please try again:  ");
        quart = Convert.ToInt32(Console.ReadLine());
    }

    if(quart == 1) Console.WriteLine("x>0,y>0");
    if(quart == 2) Console.WriteLine("x<0,y>0");
    if(quart == 3) Console.WriteLine("x<0,y<0");
    if(quart == 4) Console.WriteLine("x>0,y<0");
}

Console.Write("Please input number of quart:  ");
int quartNum = Convert.ToInt32(Console.ReadLine());

ShowDiaposon(quartNum);


// Task 2 Программа принимающая на вход координаты (X,Y) и выводит номер четверти

int Coordinates (int x, int y)
{
    int result = 0;
    if(x>0 && y>0) result = 1;
    if(x<0 && y>0) result = 2;
    if(x<0 && y<0) result = 3;
    if(x>0 && y<0) result = 4;
    return result;
}
Console.Write("Please input X coordinate:  ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input Y coordinate:  ");
int y = Convert.ToInt32(Console.ReadLine());
int result = Coordinates(x,y);
if (result == 0) 
{
    Console.WriteLine("Your Point in the begginning of coordinates.");
}
else Console.WriteLine($"Your point in  {result}  quarter.");



// Task 3 Программа (метод) Принимающий на вход координаты двух точек А (х,у) и В (х,у)
// и находит растояние между ними.

double Distance(double x_1, double x_2, double y_1, double y_2)
{
    double distance = Math.Sqrt((y_2-y_1)*(y_2-y_1)+(x_2-x_1)*(x_2-x_1));
    return distance;
}

Console.Write("Please insert X Coordinate of point A: ");
int x_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please insert Y Coordinate of point A: ");
int y_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please insert X Coordinate of point B: ");
int x_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please insert Y Coordinate of point B: ");
int y_2 = Convert.ToInt32(Console.ReadLine());

double AB = Distance(x_1,x_2,y_1,y_2);

Console.WriteLine($"Distance between point A and B {AB}");


// Task 4 Программа принимает чтсло N, и возвращает последовательность квадратов чисел от 1 до N.

void Square (int n)
{
    int current = 1;
    while(current<=n)
    {
        Console.Write(current*current+"  ");
        current++;
    }
}
Console.WriteLine();
Console.WriteLine("Hello, this program can help you find all square numbers of your number!");
Console.WriteLine();
Console.Write("Input your number for (N): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Clear();
Console.WriteLine();
Console.Write($"Your Square numbers from 1 to {n}: ");
Square(n);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Thank you!");
Console.WriteLine();
*/