

//Write a program that performs the sum , difference , multiplication , quotient and mode of two numbers
//entered by the user from the keyboard .
void Question1() {
    double num1, num2;
    Console.WriteLine("Enter the first number");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("The sum of the two numbers is {0}", num1 + num2);
    Console.WriteLine("The difference of the two numbers is {0}", num1 - num2);
    Console.WriteLine("The product of the two numbers is {0}", num1 * num2);
    Console.WriteLine("The quotient of the two numbers is {0}", num1 / num2);
    Console.WriteLine("The mode of the two numbers is {0}", num1 % num2);
}


//Write a program that finds the arithmetic mean of four numbers entered by the user on the keyboard.
void Question2() {
    double num1, num2, num3, num4;
    Console.WriteLine("Enter the first number");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the third number");
    num3 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the fourth number");
    num4 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("The arithmetic mean of the four numbers is {0}", (num1 + num2 + num3 + num4) / 4);
}



//Write a program that finds the area and perimeter of a triangle whose right sides are entered by the user from the keyboard.
void Question3() {
    int side1, side2, h, area, perimeter;
    Console.WriteLine("Enter the first side");
    side1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second side");
    side2 = Convert.ToInt32(Console.ReadLine());
    h = (Int32)Math.Sqrt(side1 * side1 + side2 * side2);
    area = side1 * side2 / 2;
    perimeter = side1 + side2 + h;
    Console.WriteLine("The area of the triangle is {0}", area);
    Console.WriteLine("The perimeter of the triangle is {0}", perimeter);
}




//Write a program that finds the area and perimeter of a circle whose radius is entered by the user on the keyboard.
void Question4() {
    double radius;
    double area, perimeter;
    Console.WriteLine("Enter the radius");
    radius = Convert.ToDouble(Console.ReadLine());
    area = Math.PI * radius * radius;
    perimeter = 2 * Math.PI * radius;
    Console.WriteLine("The area of the circle is {0:F2}", area);
    Console.WriteLine("The perimeter of the circle is {0:F2}", perimeter);
}




//Write the program that finds the amount of money in TL by the user from the keyboard,
//and how many Euros and dollars in TL, according to the Euro and Dollar rate entered by the user.
void Question5() {
    double amount, euro, dollar;
    Console.WriteLine("Enter the amount of money in TL");
    amount = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the Euro rate");
    euro = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the Dollar rate");
    dollar = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("The amount of money in Euro is {0:F2}", amount / euro);
    Console.WriteLine("The amount of money in Dollar is {0:F2}", amount / dollar);
}



// Transfers Operators


//Write a program that performs the sum , multiplication and mode operations of the
//numbers entered by the user from the keyboard with abbreviated transfer operators.
void Question6() {
    int num1, num2;
    Console.WriteLine("Enter the first number");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    num2 = Convert.ToInt32(Console.ReadLine());
    num1 += num2;
    Console.WriteLine("The sum of the two numbers is {0}", num1);
    num1 -= num2;
    Console.WriteLine("The difference of the two numbers is {0}", num1);
    num1 *= num2;
    Console.WriteLine("The product of the two numbers is {0}", num1);
    num1 /= num2;
    Console.WriteLine("The quotient of the two numbers is {0}", num1);
    num1 %= num2;
    Console.WriteLine("The mode of the two numbers is {0}", num1);
}



//Bitwise Operators

//Write a program that prints the results obtained using the logical operators
//AND, OR, XOR for two numbers entered by the user from the keyboard.
void Question7() {
    int num1, num2;
    Console.WriteLine("Enter the first number");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The result of the AND operator is {0}", num1 & num2);
    Console.WriteLine("The result of the OR operator is {0}", num1 | num2);
    Console.WriteLine("The result of the XOR operator is {0}", num1 ^ num2);
}

Question7();

//Write a program that prints the sum of two numbers entered by the user from the keyboard
//using the 3 bit right and 4 bit shift operators to the screen.
void Question8() {
    int num1, num2;
    Console.WriteLine("Enter the first number");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The result of the 3 bit right shift operator is {0}", num1 >> 3);
    Console.WriteLine("The result of the 4 bit left shift operator is {0}", num2 << 4);
}

