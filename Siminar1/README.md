# Examples from First Siminar


## Types of variables

* int number = 5; 
* double number = 2.415; 
* string name = "Paul"; 
* char symbol = '#'; 
* bool logic = true;
*  "*/ and /*" Делает код неактивным

## Examples
## Task 1

int num1, num2;

Console.Write("Input first integer number: ");

num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");

num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)

    Console.WriteLine ("Yes");
	
else

    Console.WriteLine("No");

## Task 2

Console.Write("Input positive integer number: ");

int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current<= num)

{

    Console.Write(current + " ");
    current++;
	
}


## Task 3 показать определенное количество чисел

1234 / 10 -> 123

1234 / 100 -> 12

1234 % 10 -> 4 // остаток деления на десять

1234 % 100 -> 34 // остаток деления на сто 

1234 / 10 % 100 -> 23

## Task 4 Показать три первые цифры числа

int num = 1325241325;

while(num >999)

{
    num /=10; // тоже самое что и num = num /10;
}

Console.Write(num);

## Task with day of the week

Console.Write("Input day of the week, from 1 to 7 :");

int num = Convert.ToInt32(Console.ReadLine());

if(num > 7 ||num < 1) // "||" Работает как или;

{

    Console.Write("This is incorrect day of rhe week!");
    
}

else

{

    if (num == 1) Console.Write("Monday");
	
    if (num == 2) Console.Write("Tuesday");
	
    if (num == 3) Console.Write("Wednesday");
	
    if (num == 4) Console.Write("Thuesday");
	
    if (num == 5) Console.Write("Friday");
	
    if (num == 6) Console.Write("Saturday");
	
    if (num == 7) Console.Write("Sunday");
	
}


