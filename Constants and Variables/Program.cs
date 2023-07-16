
//Constants
Question1();

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
