
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

Question2();

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
