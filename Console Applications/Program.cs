
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


//BackgroundColor and ForegroundColor Methods

//Using the BackgroundColor and ForegroundColor methods,
//write a program that displays UNITY! in black on a white background.
void Question7()
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Clear();
    Console.WriteLine("UNITY!");
}


//ConsoleKeyInfo Structure

//Write a program that finds which key was
//pressed on the keyboard using the ConsoleKeyInfo method.
void Question8()
{
    ConsoleKeyInfo key;
    Console.Write("Press a key:");
    key = Console.ReadKey(true);
    Console.WriteLine();
    Console.WriteLine($"You pressed a key {key.Key.ToString()}");
}


//SetCursorPosition Method

//Write a program that puts 100 * characters in
//random positions on the screen using the SetCursorPosition method.
void Question9()
{
    Random rnd = new Random();
    Console.SetWindowSize(30,20);
    for (int i = 0; i < 100; i++)
    {
        int width = rnd.Next(1, 29);
        int height = rnd.Next(1, 19);
        Console.SetCursorPosition(width,height);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("*");
        System.Threading.Thread.Sleep(150);
    }
}


