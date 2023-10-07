
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

//Write a program to find the roots of a quadratic equation using the if - else command.
void Question6()
{
    double a, b, c, delta, x1, x2;
    Console.WriteLine("ax2 + bx + c = 0 denklemi icin");
    Console.Write("a katsayisini giriniz :");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b katsayisini giriniz :");
    b = Convert.ToDouble(Console.ReadLine());
    Console.Write("c katsayisini giriniz :");
    c = Convert.ToDouble(Console.ReadLine());
    delta = b * b - 4 * a * c;
    if (delta > 0)
    {
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("Denklemin iki farkli kok vardir");
        Console.WriteLine($"x1 = {x1} ve x2 = {x2}");
    }
    else if (delta == 0)
    {
        x1 = -b / (2 * a);
        Console.WriteLine("Denklemin iki esit koku vardir");
        Console.WriteLine("x1 = x2 = {x1}");
    }
    else
    {
        Console.WriteLine("Denklemin kokleri yoktur");
    }
}

Question7();
//After the user is asked for gender (m/f), military status (has he/she done it? y/n) and age
//information, write the program with the if-else command in which applications are accepted
//only from men (m), those who have done their military service and those who are 30 years old
//or younger.
void Question7() {
    Console.Write("Gender (m/f) :");
    char gender = Convert.ToChar(Console.ReadLine());
    if (gender == 'm') {
        Console.Write("Military status (has he/she done it? y/n) :");
        char militaryStatus = Convert.ToChar(Console.ReadLine());
        if (militaryStatus == 'y') {
            Console.Write("Age :");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 30) {
                Console.Write("You are hired");
            } else {
                Console.Write("Those under the age of 31 will be admitted.");
            }
        } else {
            Console.Write("Personnel who have completed their military service will be recruited.");
        }        
    } else {
        Console.Write("Only man can apply");
    } 
}    
    