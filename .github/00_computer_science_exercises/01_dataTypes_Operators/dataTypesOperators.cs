// Data types and operators, Goodwine jermya, v0.0 
using System;
class dDataTypesOperator {
  static void Main() {
    // This is a comment, it gets ignored.


    /*
    this is still a comment.
    end a comment> */

    //  DATA TYPES
    // C# is statically typed -- once a variable has a data type, it cannnot be changed.

    // FLOAT - float -- decimal numbers, +/- including 0.0

    // DOUBLE - double -- decimal n8mbers, +/-, including 0.0 <---- most commonly used decimal.

    // Integer - int -- whole numbers, +/- including 0.
    
    // Variables are 'buckets' with a name to store data inside.

    // DECLARING (CREATION VARIABLES)
    // METHOD#1 -- Declared But Not Assigned
    // dataType variableName :


    // int myInteger;
    // double myDouble;

    // //Method #2 -- declare and assign.
    // int myInteger2 = 1;
    // double myDouble2 = 2.050;

    // // String -- collections of intergers,numbers, special characters.
    // string myString ="eat this string man!"

    // //boolean -- bool - True or false value
    // bool myBool = true;
    // bool spiderMonkeyabilities = false; // doesn't have spider monkey abilities.
    // bool HasPurpleKey = true; // they have the key in their inventory.

    // //Character -- char -- a single character
    // char myCharacter 'R';

    // // ASSIGNING VALUES AFTER DECLARATION

    // myInteger = 6;
    // myDouble

    // // Printing Variables To The Console Terminal
    // Console.WriteLine(myInteger)
    // Console.WriteLine(myDouble)

    // //Operators -- arithmetic
    // //addition
    // int myNewInt = myInteger + myInteger2;
    // double mydouble = myDouble + myDouble2;
    // double myNewNumber = myInteger + myDouble;

   
    // //SUBTRACTION
    // myNewNumber = myDouble - myInteger;
  
    // //DIVISION
    // myNewNumber = myDouble / myInteger;

    // //MULTIPLICATION
    // myNewNumber = myDouble * myInteger;

    // //MODULUS -- Divides, then returns the remainder
    // // most commonly used to determine even or odd.
    // myNewNumber = myDouble %2;

    // int students = 6;
    // int numSlices = 36;
    // int leftOvers;

    // leftOvers = numSlices % students;

    // // Increment / Devrement -- Most frequently used in loops.
    // int x = 0;
    // x++ // what is x egual to now?
    // // Increment ++ adds 1 to the current value and puts the new value back in the bucket.
    // x--
    // //  Decrement -- subtracts 1 from the current value and puts the new value into the bucket.

    // // special assignment operators

    // x += 1;
    // x *= 1;
    // x /= 1;
    // x -= 1;
    // x %= 1;
    // // Takes the current value, performs the calculation, put the new value into bucketl.

    // // COMPARISON OPERATORS
    // // EVALUATE THE EXPRESSION. RETURN true or false/
    // int y= 5;
    // int Z= 3;

    // // IS EQUAL TO == is the value on the left equal to the right???
    // control.WriteLine(y == Z);

    // // NOT EQUAL TO != IS THE VALUE ON THE LEFT NOT EQUAL TO THE VALUE ON THE RIGHT??
    //  control.WriteLine(y != Z);

    // // GREATER THAN >
    // control.WriteLine(y > z);

    // // GREATER THAN-OR-EQUAL-TO >=
    // control.WriteLine(y >= z);

    // // LESS THAN <
    // Console.WriteLine(y < z);

    // // LESS THAN-OR-EQUAL-TO <=
    // Console.WriteLine(y <= z);

    // //LOGICAL OPERATORS
    // int b = 1;
    // double c == 2.00;
    // string favColor = "Pink"
    // // logical AND && -- all statements must  be true 
    // Console.WriteLine(b > 1 && c != 5.00);
    // Console.WriteLine(b == 1 && c < 10.0);

    // // IF ONE EXPRESSION MOST LIKELY TO BE FALSE CHECK FOR IT FIRST!!
    // console.WriteLine(HasPurpleKey == true == playerLevel > 5);
    // console.WriteLine(HasPurpleKey == true == playerLevel > 5);

    // // Logical OR || -- one statement must be true.
    // console.Writeline((b > 1) || c != 5.0D): // true bc c is not equal to 5.0
    // console.writeline(!(b > -1)): //False because bpth expressions are fa-
    // // check for the statement most likely to be true first!!
    // console.writeline(hasBlueKey == true && playerLevel > 3):

    // // Logical  NOT ! -- Returns the opposite value of the expression.
    // console.writeline(b > -1); // TRUE
    // console.writeline(!(b > -1)); // False

    // Reading user input from the console / terminal
    console.writeline("What is your player name? Type it and press ENTER. \n")

    // Create a variable to store the data
    string playerName = console.ReadLine();
    // console.ReadLine() ONLY RETURNS STRING data types.
    string age = Console.ReadLine("What is you age? Type it and press ENTER. \n"):
    console.writeline(age + age);
    // adding string data types togeter is called conctentation

    // // PRINT THE VARIABLE TO THE SCREEN>
    // console.writeline("your player name is" + playerName);

    // INPUTTING NUMBERS FROM THE CONSOLE.
    cosnole.writeline('How many tiktoks can you like in 5 minutes? enter and interger value and press enter.\n');
    Int numTiktoks = console.writeline = Convert.ToInt32(console.ReadLine());
    Console.WriteLine(numTiktoks + numTiktoks );


/*
    you can have a singular if statement by itself.
    if you have an else you Must also have an if.
    you can use as many else if statements as you want in the code.

    */

    
    // If you are using > or >= in your control structures, check for the GREATEST VALUE FIRST!
  }
}