/*
 * Author: Jan Gomez
 * Course: Comp-003
 * Purpose: Lecture Activity for variables, type systems, Math, Console properties
 * Reference: The C# Players Guidebook (4e) by RB Whitaker
 */
namespace Comp003A.LectureActivity2;
class Program
{
    static void Main(string[] args)
    {
        /* Working with variables */
        // the folowing code shows all three primary-variable actdivities:
        string username; // declaring a variable (1 of 3)
        Console.WriteLine("What is your name?");  // request for user input
        username = Console.ReadLine(); // assigning a value to a variable (2 of 3)
        Console.WriteLine("Hi" + username); // retrieving its current value (3 of 3)


        // another example of the three primary variable related activities
        // (declaring, assigning, and retrieving)
        string favoriteColor;
        Console.WriteLine("What is your favorite color?");
        favoriteColor = Console.ReadLine();
        Console.WriteLine("Your favorite color is " + favoriteColor);


        /* working with variable integers */
        int score; // declare a new variable with a data type int
        // score = " Generic User"; // will fail to compile you are assigning
        // a string value to an integer variable
        // svore = "0"; // will still fail because the "0" is still aissigned
        // as a string - enclosed in the double quotes
        score = 0;// works
        score = 4; // you can also reassign values to the variable as long as
        // they are within scope and not constant
        score = 11;
        score = -1564;


        /* reading from a variable does not change it */
        int a;
        int b;

        a = 5;
        b = 2;
        Console.WriteLine("The variable of a: " + a);
        Console.WriteLine("The variable of b: " + b);

        /* variables are case sensitive */
        // the variables below are different despite having similar names
        string exampleVariable;
        string exampleVAriable;
        string exampleVARiable;

        Console.WriteLine("****************************************************");
        /*
         * types of variables and values matter in C#. they are not interchangable.
         * there are eight integer types for storing integers of differing sizes and ranges:
         int, short, long, byte, sbyte, unit, ushort, and ulong.
         * the char type stores single characters.
         * the string type stores longer text.
         * ther are three types for storing real numbers: float, double, and decimal.
         * the bool type stores truth values (true and false) used in logic.
         * using var for a variable's type tells the compiler to infer its type from
         the surrounding code, so you do not have to type it out. (But it still has
        a specific type.)
         * the System.Convert class is a useful class to convert from one type to another.
         */
        /* declaring and using variables with integer types */
        byte aSingleByte = 34;
        Console.WriteLine("aSingleByte: " + aSingleByte);
        aSingleByte = 17;
        Console.WriteLine("aSingleByte: " + aSingleByte);

        short aNumber = 5039;
        Console.WriteLine("aNumber: " + aNumber);
        aNumber = -4354;
        Console.WriteLine("aNumber: " + aNumber);

        long aVeryBigNumber = 395904282569;
        Console.WriteLine("aVeryBigNumbner: " + aVeryBigNumber);
        aVeryBigNumber = 13;
        Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);

        int anInteger = 2147483647;

        /* declaring, using, and concatenating characters ans strings */
        char aLetter = 'A'; // character values are enlosed in single quotes
        string message = "Hello World!"; // string value are ebclosed in double quotes

        Console.WriteLine("Concatenation using + : " + aLetter + " " + message);
        // use the plus (+) sign in between characters/strings to concatenate
        Console.WriteLine($"Concatenation using string interpolation : (aLetter) {message} ");
        //use string interpolation with a dollar-sign ($) before the opening double-quote and
        //enclosing variables with curly braces ({variableName})

        /* floating-point types*/
        double number1 = 3.5623;
        float number2 = 3.5623f;
        decimal number3 = 3.5623m;
        Console.WriteLine($"Value of number1: (number1)");
        Console.WriteLine($"Value of number2: (number2)");
        Console.WriteLine($"Value of number3: (number3)");

        /* scientific notation*/
        double avogadrosNumber = 6.022e23;
        Console.WriteLine($"Value of avogradosNumber: (avogradosNumber");

        /* bool type */
        bool itWorked = true;
        Console.WriteLine($"New value of itWorked: (itWorked)");

        /* convert */
        string inputAgeString;
        int inputAge;
        int currentYear = 2023;
        Console.WriteLine($"21 (currentYear): ");

        Console.WriteLine("**************************************************");
        /*
         * math operations
         * addition: +
         * subtraction: -
         * multiplication: *
         * division: /
         * modulo % (remainder)
         */
        int addition = 2 + 3;
        int substraction = 5 - 2;
        int multiplication = 22 * 2;
        int division = 21 / 7;
        int modulo = 77 % 5;
        Console.WriteLine($"Value of addition: (addition)");
        Console.WriteLine($"Value of substraction: (substraction)");
        Console.WriteLine($"Value of multiplication: (multiplication)");
        Console.WriteLine($"Value of division: (division)");
        Console.WriteLine($"Value of modulo: (modulo)");

        /*
         * arithmetic, compund expressions and order of operations
         * Multiplication and division are done first left to right
         * Addition and substraction are done last, left to right
         * Reference: https://csharpplayersguide.com/articles/operators-table
         */

        int arithmetic1; //declaring the variable arithmetic1.
        arithmetic1 = 9 - 2; // assigning a value to arithmetic1, using some math.
        Console.WriteLine($"New Value of arithmeticl: (arithmeticl)");
        arithmetic1 = 3 + 3; // another assignment
        Console.WriteLine($"New value of arithmetic1: (arithmetic1)");
        int arithmetic2 = 3 + 1; // declaring arithmetic2 and assigning a value to arithmetic2 all at once.
        Console.WriteLine($"Value of arithmetic2: (arithmetic2)");
        arithmetic2 = 1 + 2; // assigning a second value to arithnetic2.
        Console.WriteLine($"New Value of arithmetic2: (arithmetic2)");

        // use multiple sets of parentheses to group operations
        int result = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
        Console.WriteLine($"Value of result: (result)");

        /* compound assignment operator */
        int compoundAssignmentOperator = 0;
        compoundAssignmentOperator += 5; // The equivalent of
        // compoindAssignmentOperator = compundAssignmentOperator + 5; (a is 5 after this line runs.)
        compoundAssignmentOperator -= 2; // The equivalent of
        // compoundAssignmentOperator = compoundAssignmentOperator - 2; ( a is 3 after this line runs.)
        compoundAssignmentOperator *= 4; // The equivalent of
        // compoundAssignmentOperator = compoundAssignmentOperator * 4; ( a is 12 after this line runs.)
        compoundAssignmentOperator /= 2; // The equivalent of
        // compoundAssignmentOperator = compoundAssignmentOperator / 2; ( a is 6 after this line runs.)
        compoundAssignmentOperator %= 2; // The equivalent of
        // compoundAssignmentOperator = compoundAssignmentOperator % 2; ( a is 0 after this line runs.)

        /* increment and decrement operators */
        int incrementDecrementOperators = 0;
        incrementDecrementOperators++; // The equivalent of incrementDecrementOperator += 1; or
        // incrementDecrementOperator = incrementDecrementOperator + 1;
        incrementDecrementOperators--; // The equivalent of incrementDecrementOperator -= 1; or
        // incrementDecrementOperator = incrementDecrementOperator - 1;

        Console.WriteLine("**************************************************");
        /* console 2.0 */
        Console.WriteLine("What is your name, human? "); // notice the spave at the end.
        string userName = Console.ReadLine(); // reads the entire line
        //result: What is your name, human? Jan

        Console.WriteLine("Press any key when you're ready to begin. ");
        Console.ReadKey(); // reads a keystroke

        Console.BackgroundColor = ConsoleColor.Yellow; // change the console background to yellow
        Console.ForegroundColor = ConsoleColor.Black; // changes the console text to black
        Console.Title = "Hello world!"; // changes the console title

        Console.Beep(440, 1000); // computer beeps
    }
}

