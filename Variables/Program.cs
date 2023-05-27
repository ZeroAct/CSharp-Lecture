// int age;
// age = 25;
// Console.WriteLine(age);

// int maxValueForInt = int.MaxValue;
// int minValueForInt = int.MinValue;
// Console.WriteLine($"Max value for int: {maxValueForInt}");
// Console.WriteLine($"Min value for int: {minValueForInt}");

// byte byte1 = 130;  // 0 to 255 (1 byte of memory)
// byte age = 25;  // this it not necessary
// int myAge = 25;  // this is better

// int int1 = 1_000_000;  // -2,147,483,648 to 2,147,483,647 (4 bytes of memory)

// sbyte sbyte1 = -128;  // -128 to 127 (1 byte of memory)
// short short1 = 32767;  // -32,768 to 32,767 (2 bytes of memory)
// ushort ushort1 = 65535;  // 0 to 65,535 (2 bytes of memory)
// uint uint1 = 4_000_000_000;  // 0 to 4,294,967,295 (4 bytes of memory)

// long long1 = 9_000_000_000_000_000_000;  // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 (8 bytes of memory)
// ulong ulong1 = 18_000_000_000_000_000_000;  // 0 to 18,446,744,073,709,551,615 (8 bytes of memory)


// float float1 = 1.5F;  // -3.402823e38 to 3.402823e38 (4 bytes of memory)
// double double1 = 1.5;  // -1.79769313486232e308 to 1.79769313486232e308 (8 bytes of memory)
// decimal decimal1 = 1.5M;  // -79228162514264337593543950335 to 79228162514264337593543950335 (16 bytes of memory)

// bool bool1 = true;  // true or false (1 byte of memory)

// char char1 = 'a';  // any Unicode character (2 bytes of memory)
// string string1 = "Hello World!";  // any Unicode character (2 bytes of memory per character)
// string string2 = "\\ \" \n \t \b \r \f \v \a \0 \u0041 \x0041";  // escape characters
// string multilineString = @"This is a
// multiline string";  // multiline string
// string withoutEscapeCharacters = @"C:\Users\John\Desktop\MyApp";  // without escape characters
// string withoutEscapeCharacters2 = @"C:\Users\John\Desktop\MyApp""""";  // without escape characters (double quotes)
// string usingThreeDoubleQuotes = """Hello "Zero"!""";  // using three double quotes enables double quotes inside the string


// // Datetime
// DateTime now = DateTime.Now;
// DataTime firstDayOfTheYear = new DateTime(2020, 1, 1);
// DateTime tomorrow = now.AddDays(1);

// // int int = 1;
// int @int = 1;  // @ is used to escape reserved keywords

// var number = 1;  // var is used to infer the type of the variable
// var name = "John";
// var isWorking = true;

// // var age; // error: var must be initialized

// int age = default;  // default value for int is 0
// int age = default(int);  // default value for int is 0


// // Value types: bool, byte, char, decimal, double, enum, float, int, long, sbyte, short, struct, uint, ulong, ushort
// // place in stack
// // can be null if nullable

// // int age = null;  // error: int is not nullable
// int? age = null;  // nullable int

// // Reference Type: string, object, dynamic, class, interface, delegate, array
// // place in heap
// // can be null

// // Nullable
// string? name = null;  // nullable string

// Console.WriteLine(name);  // null
// Console.WriteLine(name?.ToUpper());  // Default


// var firstName = "John";
// var lastName = "Doe";
// var fullName = firstName + " " + lastName;

// Console.WriteLine(fullName);  // John Doe

// // Prevent overflow
// checked
// {
//     int x = int.MaxValue;
//     int y = x + 1;  // error: System.OverflowException: Arithmetic operation resulted in an overflow.
// }


// // string interpolation
// var name = "John";
// var age = 25;
// var fullName = $"{name} {age}";

// Console.WriteLine(fullName);  // John 25

// // Unary expressions
// int x = 1;
// int y = -x;  // -1

// Console.WriteLine(y);  // -1
// Console.WriteLine(-y);  // 1
// Console.WriteLine(y++); // -1
// Console.WriteLine(y);  // 0
// Console.WriteLine(++y);  // 1

// // Assigning operators
// int x = 1;
// x += 2;  // x = x + 2
// x -= 2;  // x = x - 2
// x *= 2;  // x = x * 2
// x /= 2;  // x = x / 2

// // Comparison operators
// int x = 1;
// int y = 2;

// Console.WriteLine(x == y);  // false
// Console.WriteLine(x != y);  // true
// Console.WriteLine(x > y);  // false
// Console.WriteLine(x < y);  // true
// Console.WriteLine(x >= y);  // false

// // Order of precedence
// int x = 1;
// int y = 2;
// int z = 3;

// Console.WriteLine(x + y * z);  // 7
// Console.WriteLine((x + y) * z);  // 9


// // Constants: const, readonly
// const float Pi = 3.14F;
// // Pi = 1;  // error: A constant cannot be assigned to (except in a static constructor or a variable initializer)


// // Warnings and errors
// int x = 1;  // warning: The variable 'x' is assigned but its value is never used
// #pragma warning disable 219 // disable warning
// int y = 2;  // same but no warning
// #pragma warning restore 219 // restore warning



