
//Constants

//Enter the program that finds the total fee to be paid by a family
//with 3 children (student) (parents and 3 children) who goes to a movie theater
//with a full ticket price of 10 TL and a student ticket price of 7 TL.
//(Ticket prices will be entered into the program as fixed.)
void Question1()
{
    const int fullTicket = 10, studentTicket = 7;
    int fullTicketNumber, StudentTicketNumber, total;
    Console.Write("How many full ticket: ");
    fullTicketNumber = Int32.Parse(Console.ReadLine());
    Console.Write("How many student ticket: ");
    StudentTicketNumber = Int32.Parse(Console.ReadLine());
    total = fullTicket * fullTicketNumber + studentTicket * StudentTicketNumber;
    Console.WriteLine($"Total : {total}");
}


//Question 2: Write a program that assigns values to variables of type decimal,
//string, int, sbyte, double, char, bool, float, and short, and then prints them vertically on the screen.
void Question2()
{
    decimal a = 1.5m;
    string b = "Hello";
    int c = 5;
    sbyte d = 1;
    double e = 1.5;
    char f = 'a';
    bool g = true;
    float h = 1.5f;
    short i = 1;
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
    Console.WriteLine(e);
    Console.WriteLine(f);
    Console.WriteLine(g);
    Console.WriteLine(h);
    Console.WriteLine(i);
    Console.ReadKey();
}



//Variable Types Based on Where They Are Defined


//Write a program that finds the product of the general variable g and the local variable y.
int g = 5;
void Question3()
{
    int y = 10;
    Console.WriteLine(g * y);
    Console.ReadKey();
}




//User-defined data types

//After defining the month names in the year as enums,
//write the program that finds the name of the month the user enters as numbers.
void Question4()
{
    Console.Write("Enter the month number: ");
    int month = Int32.Parse(Console.ReadLine());
    Console.WriteLine((Months)month);
    Console.ReadKey();
}




//Learn Variable Types


//Write the program that finds the type of the variables we use in the program using the GetType method.

void Question5()
{
    int a = 5;
    string b = "Hello";
    double c = 1.5;
    char d = 'a';
    bool e = true;
    Console.WriteLine(a.GetType());
    Console.WriteLine(b.GetType());
    Console.WriteLine(c.GetType());
    Console.WriteLine(d.GetType());
    Console.WriteLine(e.GetType());
    Console.ReadKey();
}



//Conversion Between Variable Types
Question8();

//Write the program that divides two integers (39 and 5) entered from the keyboard and displays the result as a decimal number.
void Question6()
{
    int a = 39, b = 5;
    Console.WriteLine((double)a / b);
    Console.ReadKey();
}


//Write a program that takes the value of true (15/3=5) from the user if the operation
//given on the screen is true, and false if it is false, and measures the user's mathematical knowledge.
void Question7()
{
    Console.Write("15/3=5? (True/False): ");
    bool answer = Convert.ToBoolean(Console.ReadLine());
    if(answer) Console.WriteLine("Correct");
    else Console.WriteLine("Wrong");
    Console.ReadKey();
}



//Write a program that finds which gender value is entered according to the gender
//information entered by the user (e for male, k for female).
void Question8()
{
    char type;
    Console.WriteLine("Enter gender information (e/k): ");
    type = Convert.ToChar(Console.ReadLine());
    if (type.Equals('e'))
    {
        Console.WriteLine("Male information entered");
    }

    if (type.Equals('k'))
    {
        Console.WriteLine("Female information entered");
    }
}


enum Months
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}