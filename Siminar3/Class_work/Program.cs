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
*/

// Task 2 Программа принимающая на вход координаты (X,Y) и выводит номер четверти

void coordinates (int x, int y)
{
    if(x>0 && y>0) Console.WriteLine("Your quart number: 1 ");
    if(x<0 && y>0) Console.WriteLine("Your quart number: 2 ");
    if(x<0 && y<0) Console.WriteLine("Your quart number: 3 ");
    if(x>0 && y<0) Console.WriteLine("Your quart number: 4 ");
}

Console.Write("Please input X coordinate:  ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input Y coordinate:  ");
int y = Convert.ToInt32(Console.ReadLine());

coordinates(x,y);