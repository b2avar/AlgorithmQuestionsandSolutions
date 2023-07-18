
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
Question4();

//After defining the month names in the year as enums,
//write the program that finds the name of the month the user enters as numbers.
void Question4()
{
    Console.Write("Enter the month number: ");
    int month = Int32.Parse(Console.ReadLine());
    Console.WriteLine((Months)month);
    Console.ReadKey();
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
