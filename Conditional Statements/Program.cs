
//Write a program using the if command to find out whether
//the number entered by the user on the keyboard is 10, greater than or less than 10.
void Question1() {
    Console.Write("Write a number :");
    var number = int.Parse(Console.ReadLine());

    if (number < 10) {
        Console.Write("Number is less than 10 ");
    }
    
    if (number == 10) {
        Console.Write("Number is equals 10");
    }

    if (number > 10) {
        Console.Write("Number is greater than 10");
    }
}

//Write a program that finds out whether the character entered
//from the keyboard is a letter, a number or a special sign, using the if command.
void Question2() {
    Console.Write("Write a character :");
    var character = Convert.ToChar(Console.ReadLine());
    
    if (char.IsLetter(character)) {
        Console.Write("Character is a letter");
    }

    if (char.IsNumber(character)) {
        Console.Write("Character is a number");
    }

    if (char.IsSymbol(character)) {
        Console.Write("Character is a symbol");
    }
}



//Write a program using the if command to find the smallest of 3 different numbers entered
//by the user from the keyboard.
void Question3() {
    Console.Write("Write a number :");
    var number1 = int.Parse(Console.ReadLine());
    Console.Write("Write a number :");
    var number2 = int.Parse(Console.ReadLine());
    Console.Write("Write a number :");
    var number3 = int.Parse(Console.ReadLine());

    if (number1 < number2 && number1 < number3) {
        Console.Write($"{number1} is the smallest");
    }

    if (number2 < number1 && number2 < number3) {
        Console.Write($"{number2} is the smallest");
    }

    if (number3 < number1 && number3 < number2) {
        Console.Write($"{number3} is the smallest");
    }
}
    
//Write a program that detects whether the letter key pressed
//by the user on the keyboard is a CAPITAL letter or a lowercase letter,
//using the if-else command.
void Question4() { 
    try {
        Console.Write("Write a character :");
        var character = Convert.ToChar(Console.ReadLine());
        Console.Write(char.IsUpper(character)
            ? "Character is a capital letter"
            : "Character is a lowercase letter");
    } catch (Exception e) {
        Console.WriteLine("Please enter a character");
    }
}

//Write a program that finds whether the number entered from the keyboard is odd or even,
//using the if-else command.
void Question5() {
    Console.Write("Write a number :");
    var number = int.Parse(Console.ReadLine());
    char[] numbers = number.ToString().ToCharArray();
    Console.Write(number % 2 == 0 && number != 0 ? "Number is even" : number == 0 ? "Number is zero" : "Number is odd");
}

//Write a program to find the roots of a quadratic equation using the if - else command.
void Question6() {
    double a, b, c, delta, x1, x2;
    Console.WriteLine("ax2 + bx + c = 0 denklemi icin");
    Console.Write("a katsayisini giriniz :");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b katsayisini giriniz :");
    b = Convert.ToDouble(Console.ReadLine());
    Console.Write("c katsayisini giriniz :");
    c = Convert.ToDouble(Console.ReadLine());
    delta = b * b - 4 * a * c;
    if (delta > 0) {
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Console.WriteLine("Denklemin iki farkli kok vardir");
        Console.WriteLine($"x1 = {x1} ve x2 = {x2}");
    } else if (delta == 0) {
        x1 = -b / (2 * a);
        Console.WriteLine("Denklemin iki esit koku vardir");
        Console.WriteLine("x1 = x2 = {x1}");
    } else {
        Console.WriteLine("Denklemin kokleri yoktur");
    }
}

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

//Ternary Operator
//Make the codes that check whether the number entered by the user is less than 10, using the ternary operator.
void Question8() {
    Console.Write("Write a number :");
    var number = int.Parse(Console.ReadLine());
    Console.Write(number < 10 ? "Number is less than 10" : "Number is greater than 10");
}

//Switch Case
//Write a program that writes the phrase "I love you" to the screen in its own language,
//according to the entered foreign language, using the switch-case method.
void Question9() {
    Console.WriteLine("Language Selection");
    Console.WriteLine("1- Turkish");
    Console.WriteLine("2- English");
    Console.WriteLine("3- French");
    Console.WriteLine("4- German");
    Console.Write("Select language :");
    int language = Convert.ToInt32(Console.ReadLine());
    switch (language) {
        case 1:
            Console.Write("Seni seviyorum");
            break;
        case 2:
            Console.Write("I love you");
            break;
        case 3:
            Console.Write("Je t'aime");
            break;
        case 4:
            Console.Write("Ich liebe dich");
            break;
        default:
            Console.Write("Wrong language selection");
            break;
    }
}

//Write a program that finds the season of the moon according to the entered month information, using the switch-case method.
void Question10() {
    Console.Write("Enter month :");
    int month = Convert.ToInt32(Console.ReadLine());
    switch (month) {
        case 1:
        case 2:
        case 3:
            Console.Write("Winter");
            break;
        case 4:
        case 5:
        case 6:
            Console.Write("Spring");
            break;
        case 7:
        case 8:
        case 9:
            Console.Write("Summer");
            break;
        case 10:
        case 11:
        case 12:
            Console.Write("Autumn");
            break;
        default:
            Console.Write("Wrong month selection");
            break;
    }
}


//After entering two numbers and four simple mathematical operation symbols (+ ·) on the keyboard,
//write a program that performs the necessary operations and writes the result to the screen using the switch-case method.
void Question11() {
    Console.Write("Write a number :");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Write a number :");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Write a operation (+ - * /) :");
    char operation = Convert.ToChar(Console.ReadLine());
    switch (operation) {
        case '+':
            Console.Write(number1 + number2);
            break;
        case '-':
            Console.Write(number1 - number2);
            break;
        case '*':
            Console.Write(number1 * number2);
            break;
        case '/':
            Console.Write(number1 / number2);
            break;
        default:
            Console.Write("Wrong operation selection");
            break;
    }
}

//Write a program using the switch-case method to find out which day the given date is based
//on the day / month / year information entered by the user from the keyboard and write it to the screen.
void Question12() {
    Console.Write("Enter day :");
    int day = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter month :");
    int month = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter year :");
    int year = Convert.ToInt32(Console.ReadLine());
    DateTime date = new DateTime(year, month, day);
    switch (date.DayOfWeek) {
        case DayOfWeek.Monday:
            Console.Write("Monday");
            break;
        case DayOfWeek.Tuesday:
            Console.Write("Tuesday");
            break;
        case DayOfWeek.Wednesday:
            Console.Write("Wednesday");
            break;
        case DayOfWeek.Thursday:
            Console.Write("Thursday");
            break;
        case DayOfWeek.Friday:
            Console.Write("Friday");
            break;
        case DayOfWeek.Saturday:
            Console.Write("Saturday");
            break;
        case DayOfWeek.Sunday:
            Console.Write("Sunday");
            break;
        default:
            Console.Write("Wrong date selection");
            break;
    }
}

    

//Loops
//Write the program that says 10 "b2avar" on the screen with the for loop.
void Question13() {
    for (int i = 0; i < 10; i++) {
        Console.WriteLine($"{i+1} b2avar ");
    }
}

//Write a program using for command to find sum of even numbers and odd numbers between 0 and 20.
void Question14() {
    var sumEven = 0;
    var sumOdd = 0;
    for (var i = 0; i <= 20; i++) {
        if (i % 2 == 0) {
            sumEven += i;
        } else {
            sumOdd += i;
        }
    }
    Console.WriteLine($"Sum of even numbers : {sumEven}");
    Console.WriteLine($"Sum of odd numbers : {sumOdd}");
}