
//Write a program using the if command to find out whether
//the number entered by the user on the keyboard is 10, greater than or less than 10.
void Question1()
{
    Console.Write("Write a number :");
    var number = int.Parse(Console.ReadLine());

    if (number < 10)
    {
        Console.Write("Number is less than 10 ");
    }
    
    if (number == 10)
    {
        Console.Write("Number is equals 10");
    }

    if (number > 10)
    {
        Console.Write("Number is greater than 10");
    }
}

//Write a program that finds out whether the character entered
//from the keyboard is a letter, a number or a special sign, using the if command.
void Question2()
{
    Console.Write("Write a character :");
    var character = Convert.ToChar(Console.ReadLine());
    
    if (char.IsLetter(character))
    {
        Console.Write("Character is a letter");
    }

    if (char.IsNumber(character))
    {
        Console.Write("Character is a number");
    }

    if (char.IsSymbol(character))
    {
        Console.Write("Character is a symbol");
    }
}



//Write a program using the if command to find the smallest of 3 different numbers entered
//by the user from the keyboard.
void Question3()
{
    Console.Write("Write a number :");
    var number1 = int.Parse(Console.ReadLine());
    Console.Write("Write a number :");
    var number2 = int.Parse(Console.ReadLine());
    Console.Write("Write a number :");
    var number3 = int.Parse(Console.ReadLine());

    if (number1 < number2 && number1 < number3)
    {
        Console.Write($"{number1} is the smallest");
    }

    if (number2 < number1 && number2 < number3)
    {
        Console.Write($"{number2} is the smallest");
    }

    if (number3 < number1 && number3 < number2)
    {
        Console.Write($"{number3} is the smallest");
    }
}
    
//Write a program that detects whether the letter key pressed
//by the user on the keyboard is a CAPITAL letter or a lowercase letter,
//using the if-else command.
void Question4()
{ 
    try
    {
        Console.Write("Write a character :");
        var character = Convert.ToChar(Console.ReadLine());
        Console.Write(char.IsUpper(character)
            ? "Character is a capital letter"
            : "Character is a lowercase letter");
    }
    catch (Exception e)
    {
        Console.WriteLine("Please enter a character");
    }
}

//Write a program that finds whether the number entered from the keyboard is odd or even,
//using the if-else command.
void Question5()
{
    Console.Write("Write a number :");
    var number = int.Parse(Console.ReadLine());
    char[] numbers = number.ToString().ToCharArray();
    Console.Write(number % 2 == 0 && number != 0 ? "Number is even" : number == 0 ? "Number is zero" : "Number is odd");
}

