// Array

char[] vowels = new char[5];  // array of 5 chars

vowels[0] = 'a';
vowels[1] = 'e';
vowels[2] = 'i';
vowels[3] = 'o';
vowels[4] = 'u';

Console.WriteLine(vowels);  // a

foreach (var vowel in vowels)
{
    Console.WriteLine(vowel);
}

for (var i = 1; i <= vowels.Length; i++)
{
    Console.WriteLine(vowels[^i]);
}

Console.WriteLine(vowels[..3]); // aei
Console.WriteLine(vowels[2..]); // iou
Console.WriteLine(vowels[1..4]); // eio
Console.WriteLine(vowels[..]); // aeiou


Range range = 1..4;
Console.WriteLine(vowels[range]); // eio


// Two dimensional array
int[,] matrix = new int[2, 3];  // 2 rows and 3 columns

matrix[0, 0] = 1;
matrix[0, 1] = 2;
matrix[0, 2] = 3;
matrix[1, 0] = 4;
matrix[1, 1] = 5;
matrix[1, 2] = 6;

int[,] matrix2 = new int[2, 3] { 
    { 1, 2, 3 }, 
    { 4, 5, 6 }
};


for (int row = 0; row < matrix2.GetLength(0); row++)
{
    for (int column = 0; column < matrix2.GetLength(1); column++)
    {
        Console.Write($"{matrix2[row, column]} ");
    }
    Console.WriteLine();
}


// Jagged array
int[][] matrix3 = new int[2][];  // 2 rows

matrix3[0] = new int[3] { 1, 2, 3 };
matrix3[1] = new int[2] { 4, 5 };

for (int row = 0; row < matrix3.Length; row++)  // can assign to 'row' because it is a 'for loop variable'
{
    for (int column = 0; column < matrix3[row].Length; column++)
    {
        Console.Write($"{matrix3[row][column]} ");
    }
    Console.WriteLine();
}

foreach (var row in matrix3)  // cannot assign to 'row' because it is a 'foreach iteration variable'
{
    foreach (var column in row)
    {
        Console.Write($"{column} ");
    }
    Console.WriteLine();
}



// String manipulation
var firstName = "Mosh";

Console.WriteLine(firstName.ToUpper());  // M

if (firstName.Equals("MOSH", StringComparison.InvariantCultureIgnoreCase))
    Console.WriteLine("Same");
else
    Console.WriteLine("Different");


var firstNamewithSpaces = " Mosh     ";
Console.WriteLine(firstNamewithSpaces.Trim());  // Mosh

var indetificationNumber = "123-456-789";
Console.WriteLine(indetificationNumber.Replace('-', '.'));  // 123.456.789

var amount1 = 123;
var amount2 = 123.45;
var amount3 = 123.4567;

Console.WriteLine(amount1.ToString().PadLeft(10, '0'));  // 0000000123