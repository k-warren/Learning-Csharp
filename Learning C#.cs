// Printing Hello World to the terminal
using System; 

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is basics on C#");
            Console.WriteLine("Would you like to continue");
            string decision = Console.ReadLine();
            if (decision.ToUpper() == "YES")
            {
//Adding two numbers
Console.WriteLine("-----Adding numbers-----");
int x = 5;
int y = 10;
Console.WriteLine(x + y);

//Printing variables
Console.WriteLine("-----Printing variables-----");
int a = 5;
int b = 10;
int c = a + b;
Console.WriteLine(c);

//Comma separated list
Console.WriteLine("-----Comma separated list-----");
int A = 5, B = 10, C = 15;
Console.WriteLine(A + B + C);

//Variable types
Console.WriteLine("-----Variable types-----");
int myInt = 5;
double myDouble = 5.5;
char myLetter = 'A';
string myString = "Hello World";
bool myBoolean = false;
Console.WriteLine(myInt);
Console.WriteLine(myDouble);
Console.WriteLine(myLetter);
Console.WriteLine(myString);
Console.WriteLine(myBoolean);

//Constants
Console.WriteLine("-----Constants-----");
const int myConst = 15;
Console.WriteLine(myConst);

//Converting data types
Console.WriteLine("-----Converting int to string-----");
int MyInt = 10;
Console.WriteLine(Convert.ToString(MyInt));

//User input
Console.WriteLine("-----Taking user input-----");
Console.WriteLine("Enter your name");
string name = Console.ReadLine();
Console.WriteLine("Name is: " + name);

//Print user number input
Console.WriteLine("-----Printing user input-----");
Console.WriteLine("Enter a number: ");
int Input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Input);

//Implicit casting
Console.WriteLine("-----Casting-----");
int myInteger = 9;
double myDoub = myInteger;
Console.WriteLine(myInt);
Console.WriteLine(myDoub);

//Explicit casting
double gravity = 9.813;
int gravityRound = (int) gravity;
Console.WriteLine(gravity);
Console.WriteLine(gravityRound);

//Increment
Console.WriteLine("-----Increment\\Decrement-----");
int num = 10;
num++;
Console.WriteLine(num);

//Decrement
int number = 10;
number--;
Console.WriteLine(number);

//Logical operators
Console.WriteLine("-----Logical operators-----");
int d = 5;
Console.WriteLine(d > 3 && d < 10); //returns true as 3<d<10
int e = 5;
Console.WriteLine(e > 3 || e < 4); //returns true as e>3 and e!<4
int f = 5;
Console.WriteLine(!(f > 3 && f < 10)); //returns false as it reverses the value

//Math
Console.WriteLine("-----Maths-----");
Console.WriteLine(Math.Max(5,10)); //returns max number
Console.WriteLine(Math.Min(5,10)); //returns min number
Console.WriteLine(Math.Sqrt(64)); //returns square root
Console.WriteLine(Math.Abs(-4.7)); //returns absolute value
Console.WriteLine(Math.Round(9.81)); //returns rounded to nearest whole number

//Upper and Lower
Console.WriteLine("-----Upper and lower-----");
string txt = "Hello World";
Console.WriteLine(txt.ToUpper());
Console.WriteLine(txt.ToLower());

//String concatenation
Console.WriteLine("-----String concatenation\\interpolation-----");
string firstName = "John";
string lastName = "Jones";
string fullName = firstName + lastName;
string fullName2 = string.Concat(firstName, lastName);
Console.WriteLine(fullName);
Console.WriteLine(fullName2);

//String interpolation
string pass = "Hello";
string word = "World";
string password = $"Password is: {pass} {word}";
Console.WriteLine(password);

//Access strings
Console.WriteLine("-----Access strings-----");
string myString1 = "Hello";
Console.WriteLine(myString1[0]);
Console.WriteLine(myString1.IndexOf("e"));

//Substring
Console.WriteLine("-----Substrings-----");
string name1 = "Jayden Mantits";
int charPos = name1.IndexOf("M");
string surname = name1.Substring(charPos);
Console.WriteLine(surname);

//Special Characters
Console.WriteLine("-----Special characters-----");
Console.WriteLine("This prints a \'");
Console.WriteLine("This prints a \"");
Console.WriteLine("This prints a \\");
Console.WriteLine("New \n Line");
Console.WriteLine("This \t is a tab");
Console.WriteLine("This \b is a backspace");

//Booleans
Console.WriteLine("-----Booleans-----");
bool doesOliverSuck = true;
bool isOliverCool = false;
int g = 10, h = 9;
Console.WriteLine(doesOliverSuck);
Console.WriteLine(isOliverCool);
Console.WriteLine(g > h);

//If statements
Console.WriteLine("-----If statements-----");
int age = 25;
int drivingAge = 17;

if (age >= drivingAge)
{
    Console.WriteLine("Old enough to drive");
}
else
{
    Console.WriteLine("Not old enough to drive");
}

//Else if
Console.WriteLine("-----Else if-----");
int myAge = 16;
if (myAge < 16)
{
    Console.WriteLine("You are younger than 16");
}
else if (myAge == 16)
{
    Console.WriteLine("You are 16");
}
else{
    Console.WriteLine("You are older than 16");
}

//Short hand if statements
Console.WriteLine("-----Short hand if statements-----");
int time = 10;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);
            }
else
{
    Console.WriteLine("Come again soon");
    System.Environment.Exit(1);
}
        }
    }
}