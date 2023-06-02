// var todayIsSunday = false;
// Console.WriteLine("Today is Sunday: " + todayIsSunday);
// Console.WriteLine("Today is Sunday: " + !todayIsSunday);


// var isNum1EqualNum2 = 5 == 5;
// Console.WriteLine("5 == 5: " + isNum1EqualNum2);


// var num1 = 6;
// var isBetween0And10 = num1 > 0 && num1 < 10;
// Console.WriteLine("num1 > 0 && num1 < 10: " + isBetween0And10);

// var num2 = 12;
// var isBetween0And10OrBetween11And20 = (num2 > 0 && num2 < 10) || (num2 > 11 && num2 < 20);
// Console.WriteLine("num2 > 0 && num2 < 10 || num2 > 11 && num2 < 20: " + isBetween0And10OrBetween11And20);

// string? lastName = null;
// var isLastNameEqualToJohn = lastName == "John";
// Console.WriteLine("lastName == \"John\": " + isLastNameEqualToJohn);


// var num1 = 9;
// if (num1 > 0 && num1 < 10)
// {
//     Console.WriteLine("num1 is between 0 and 10");
// }
// else if (num1 > 10 && num1 < 20)
// {
//     Console.WriteLine("num1 is between 11 and 20");
// }
// else
// {
//     Console.WriteLine("num1 is not between 0 and 20");
// }


// Ternary Conditional Operator
var num1 = 9;
var isNum1Between0And10 = num1 > 0 && num1 < 10 ? true : false;
Console.WriteLine("num1 is between 0 and 10: " + isNum1Between0And10);

// Switch Statement
var num2 = 9;
switch (num2)
{
    case 0:
        Console.WriteLine("num2 is 0");
        break;
    case 1:
        Console.WriteLine("num2 is 1");
        break;
    case 2:
        Console.WriteLine("num2 is 2");
        break;
    default:
        Console.WriteLine("num2 is not between 0 and 9");
        break;
}

// Switch expression
var num3 = 9;
var num3IsBetween0And10 = num3 switch
{
    0 => true,
    1 => true,
    2 => true,
    3 or 4 or 5 or 6 or 7 or 8 or 9 => true,
    _ => false
};

// Relational Pattern
var num4 = 9;
var num4IsBetween0And10 = num4 switch
{
    >= 0 and <= 9 => true,
    _ => false
};

// Logical Pattern
string? lastName = "John";

if (lastName is not null)
{
    Console.WriteLine(lastName.ToUpper());
}

// && = and
// || = or


// While loop
// int counter = 1;

// while (counter <= 10)
// {
//     Console.WriteLine(counter);
//     counter++;
// }

// Do While loop
int counter = 1;

do
{
    Console.WriteLine(counter);
    counter++;
} while (counter <= 10);

// For loop
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// Foreach loop
var someString = "Hello World";

foreach (var character in someString)
{
    Console.WriteLine(character);
}

// Break and Continue
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        continue;
    }

    if (i == 8)
    {
        break;
    }

    Console.WriteLine(i);
}

// Simple adding calculator
Console.WriteLine("Enter a number:");
var num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter another number:");
var num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter an operator:");
var op = Console.ReadLine();

var result = op switch
{
    "+" => num1 + num2,
    "-" => num1 - num2,
    "*" => num1 * num2,
    "/" => num1 / num2,
    _ => 0
};