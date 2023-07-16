
//Write WriteLine Methods

//Question 1: Write "Hello World!" to the console using the Write method.
void Question1()
{   
    Console.Write("Hello, World!");
}

//Question 2: Write "Hello World!" to the console using the WriteLine method.
void Question2()
{
    Console.WriteLine("Hello, World!");
}

//Question 3: Print "A=50B=25" to the console using the Write method.
//Assign the value 50 to the variable A and the value 25 to the variable B.
void Question3()
{
    int a,b;
    a=50;
    b=25;
    Console.Write($"A={a}");
    Console.Write($"B={b}");
}


//Question 4: Print "A=50B=25" to the console using the WriteLine method.
//Assign the value 50 to the variable A and the value 25 to the variable B.
void Question4()
{
    int A,B;
    A=50;
    B=25;
    Console.WriteLine($"A={A}");
    Console.WriteLine($"B={B}");
}


//Read ReadLine Methods

//Write a program that calculates the sum and average
//of 4 numbers entered by the user.
void Question5()
{
    int a, b, c, d, sum = 0, average = 0;
    Console.Write("Enter the 1st number:");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the 2st number:");
    b = int.Parse(Console.ReadLine());
    Console.Write("Enter the 3st number:");
    c = Int32.Parse(Console.ReadLine());
    Console.Write("Enter the 4st number:");
    d = Int16.Parse(Console.ReadLine());
    sum = a + b + c + d;
    Console.WriteLine($"Sum of numbers:{sum}");
    Console.WriteLine($"Average of numbers:{sum/4}");
}

//Make the program that finds the ASCII code of the key entered
//from the keyboard by using the Read command.
void Question6()
{
    int key;
    Console.Write("Press a key:");
    key = Console.Read();
    Console.WriteLine($"ASCII Code:{key}");
}


