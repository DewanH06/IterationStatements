// See https://aka.ms/new-console-template for more information


using System.ComponentModel;
using System.Runtime.ExceptionServices;
using static System.Collections.Specialized.BitVector32;
using System.Runtime.Intrinsics.X86;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

//TODO - Read each comment and complete its instruction
// like the example below

//Create a List called "numbers" - DONE!
var numbers = new List<int>();

//-----START HERE------------------------------------------
//Create a variable of type int and name it num
//initialize the variable with a value of 0
var myNumber = 0;


// Create a do-while loop and use the template below:

{
    // Increment num by 1

    // Then add num to the collection - numbers
    // Hint: reference num inside of the Add method's parentheses
   

} // <---- While your variable is less than 100
do
{
    myNumber++; //2

    numbers.Add( myNumber ); //1,2,3,4 100 

} while (myNumber < 100);


// Create a while loop
// <--- While num is less than 200
while(myNumber < 200);
{
    // Increment num by 1
    myNumber++;
    // Then add num to the collection numbers
    numbers.Add(myNumber);
    //HINT: copy how this was done in the do while loop

}


// This is to show the user that the numbers will start increasing on the console
Console.WriteLine("Increase:");


// Create a foreach loop using the collection - numbers
//In the scope of the foreach loop, print each number in numbers
foreach(var item in numbers)
{
    Console.WriteLine($"{item}");
}


Console.WriteLine("");
Console.WriteLine("Decrease:");


// Create a for loop - this will print the numbers in reverse order - from 200 to 1
// in your initializer set the value of i to 199
// in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
// AND as long as i is greater than or equal to 0
// Decrement i by 1
//start for loop here
for (int i = 199; i <= numbers.Count && 1 >= 0; i--) ;
{
    Console.WriteLine($"{numbers[199]}");
}

//------------End of exercise

///////////////////////////
///
//Write a method that will print to the console all numbers 1000 through -1000

static void Print1000s()
{
    for (var i = 1000; i >= -1000; i--)
    {
        Console.WriteLine(i);
    }
}


//Write a method that will print to the console numbers 3 through 999 by 3 each time
static void PrintThrees()
{
    for(var i =3; i <= 999; i += 3)
    {
        Console.WriteLine(i);
    }
}

//Write a method to accept two integers as parameterss and check whether they are equal or not
static void TwoIntsEqual(int num1, int num2)
{
    if (num1 == num2)
    {
        Console.WriteLine("those numbers are equal");
    }
    else
    {
        Console.WriteLine("those number are not equal");
    }
    
}

//Write a method to check whether a given number is even or odd
static void OddorEven(int number)
{
    if (number % 2 == 0)
    {
        Console.WriteLine($"{number} is even. ");
    }
    else
    {
        Console.WriteLine($"{number} is odd");
    }
}

//Write a method to check whether a given number is positive or negative
static void PositiveorNegative(int num)
{
    if(num > 0)
    {
        Console.WriteLine($"{num} is positive");
    }
    else if (num < 0)
    {
        Console.WriteLine($"{num} is Negative");
    }
    else
    {
        Console.WriteLine($"{num} is neither positive or negative");
    }
}

//Write a method to read the age of a candidate and determine whether they can vote.

//Hint: Use Parse or the safer TryParse() for an extra challenge

//Parse()
//TryParse()
static void AgeCheck()
{
    bool userAge;
    int result;

    do
    {
        Console.WriteLine("Please enter your age");

        userAge = int.TryParse(Console.ReadLine(), out result);
    }while (!userAge);

    if(result < 18)
    {
        Console.WriteLine("very sorry you are not old enough to vote");
    }
    else
    {
        Console.WriteLine("Congrtas! you can vote"  );
    }
}

//Heatin Up Section:
//Write a method to check if an integer(from the user) is in the range -10 to 10
static void InRange()
{
    bool userResponse;
    int result;

    do
    {
        Console.WriteLine("Enter an Integer");
        userResponse = int.TryParse(Console.ReadLine(), out result);
    }while(!userResponse);

    if (result >= -10 && result <= 10)
    {
        Console.WriteLine($"{result} is between -10 & 10");
    }
    else
    {
        Console.WriteLine($"{result} is NOT between -10 & 10");
    }
}

//Write a method to display the multiplication table (from 1 to 12) of a given integer
 static void MultTable()
{
    bool cont;
    int userInput;


    do
    {
        Console.WriteLine("Enter an integer");
        cont = int.TryParse(Console.ReadLine(), out userInput);
    }while (!cont);

    for (var i =1; i <= 12; i++)
    {
        Console.WriteLine($"{i} x {userInput} = {i * userInput}");
    }
}

static void main(string[] args)
{
    Print1000s();
    Console.WriteLine();

    PrintThrees();

    Console.WriteLine("Enter !st number");
    var answer1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter second number");
    var answer2 = int.Parse(Console.ReadLine());

    TwoIntsEqual(answer1, answer2);

    OddorEven(10);
    OddorEven(5);

    PositiveorNegative(100);
    PositiveorNegative(-100);
    PositiveorNegative(0);


    AgeCheck();

    InRange();
}

