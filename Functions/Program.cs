// Simple Function
string GetName()
{
    return "Mosh";
}

var myNmae = GetName();

Console.WriteLine(myNmae);


void PrintCurrentDateAndTime()
{
    Console.WriteLine(DateTime.Now);
}
PrintCurrentDateAndTime();


// 
double Average(int[] nubmers)
{
    var sum = 0.0;
    foreach (var number in nubmers)
        sum += number;

    return sum / nubmers.Length;
}

Console.WriteLine(Average(new int[] { 1, 2, 3, 4, 5 }));

// Using parmas

double Average2(params int[] nubmers)
{
    var sum = 0.0;
    foreach (var number in nubmers)
        sum += number;

    return sum / nubmers.Length;
}

Console.WriteLine(Average2(1, 2, 3, 4, 5));

double Average3(bool dummy, params int[] nubmers)
{
    var sum = 0.0;
    foreach (var number in nubmers)
        sum += number;

    return sum / nubmers.Length;
}

Console.WriteLine(Average3(true, 1, 2, 3, 4, 5));


// passing by reference
void Increment(int number)
{
    number += 10;
}

var number2 = 1;
Increment(number2);
Console.WriteLine(number2);  // 1

void Increment2(ref int number)
{
    number += 10;
}

var number3 = 1;
Increment2(ref number3);
Console.WriteLine(number3);  // 11

// but array is a reference type
void Increment3(int[] numbers)
{
    numbers[0] += 10;
}

var numbers2 = new int[] { 1, 2, 3 };
Increment3(numbers2);
Console.WriteLine(numbers2[0]);  // 11


// out parameter
int Parse(string number)
{
    int result = int.Parse(number);
    return result;
}

int result2;
var success = int.TryParse("abc", out result2);
if (success)
    Console.WriteLine(result2);
else
    Console.WriteLine("Conversion failed.");

// Using out parameter
void Doubling(int number, out int result)
{
    result = number * 2;
}

Doubling(10, out int result3);
Console.WriteLine(result3);  // 20

// Using multiple out parameter
void Doubling2(int number, out int result, out int result4)
{
    result = number * 2;
    result4 = number * 4;
}

Doubling2(10, out int result5, out int result6);
Console.WriteLine(result5);  // 20
Console.WriteLine(result6);  // 40


// Tuple
var myTuple = (1, 2);
Console.WriteLine(myTuple.Item1);  // 1
Console.WriteLine(myTuple.Item2);  // 2

(int, int) myTuple2 = (1, 2);
Console.WriteLine(myTuple2.Item1);  // 1
Console.WriteLine(myTuple2.Item2);  // 2

(int a, int b) myTuple3 = (1, 2);
Console.WriteLine(myTuple3.a);  // 1
Console.WriteLine(myTuple3.b);  // 2

(int, int) MyTuple()
{
    return (1, 2);
}

var myTuple4 = MyTuple();
Console.WriteLine(myTuple4.Item1);  // 1
Console.WriteLine(myTuple4.Item2);  // 2



// local function

// lambda expression
int Sum(int a, int b)
{
    return a + b;
}

int Sum2(int a, int b) => a + b;

Console.WriteLine(Sum(1, 2));  // 3
Console.WriteLine(Sum2(1, 2));  // 3



// Stroing Void Functions in a Variable
Action printMesage;
void PrintDateAndTime()
{
    Console.WriteLine(DateTime.Now);
}

void PrintName()
{
    Console.WriteLine("Mosh");
}

printMesage = PrintDateAndTime;
printMesage();  // 2021-08-22 12:00:00 AM

printMesage = PrintName;
printMesage();  // Mosh


// Passing a function as parameter
void Process(Action action)
{
    Console.WriteLine("Started...");
    action();
    Console.WriteLine("Done.");
}

Process(PrintDateAndTime);

Action<int, int> printSum;
printSum = (a, b) => Console.WriteLine(a + b);
printSum(1, 2);  // 3


// Func
Func<string> returnString;
returnString = () => "Mosh";
Console.WriteLine(returnString());  // Mosh

Func<int, int, int> sum;  // last int is return type
sum = (a, b) => a + b;
Console.WriteLine(sum(1, 2));  // 3


// Predicates
Predicate<string> isUpper;
isUpper = (text) => text.Equals(text.ToUpper());
Console.WriteLine(isUpper("hello"));  // False


// Delegate
TryParseDelegate myDelegate = TryParse;

if (myDelegate("123", out int result7))
    Console.WriteLine(result7);
else
    Console.WriteLine("Conversion failed.");

bool TryParse(string value, out int result)
{
    return int.TryParse(value, out result);
}


// Anonymous Methods
Process(() => Console.WriteLine("Hello World"));
Process(() =>
{
    Console.WriteLine("Hello World");
    Console.WriteLine("Hello World");
});

delegate bool TryParseDelegate(string value, out int result);


// Action is a delegate type that returns void
// Func is a delegate type that returns a value
// Predicate is a delegate type that returns a boolean value
// Delegate is a reference type that can be used to encapsulate a named or an anonymous method