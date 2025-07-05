using System.Xml;
using System.Globalization;

Action printLine = () =>
    Console.WriteLine("\n----------------------------------------------------------\n");

#region object type
object height = 1.88; // storing a double in an object
object name = "Amir"; // storing a string in an object
Console.WriteLine($"{name} is {height} meters tall.");

// int length1 = name.Length; // this gives a compiler error
int length2 = ((string)name).Length; // cast name to a string
Console.WriteLine($"{name} has {length2} characters.");
printLine();
#endregion

#region dynamic type
dynamic something;

// storing an array of int values in a dynamic object
// an array of any type has a Length property
something = new[] { 3, 5, 7 };

// storing an int in a dynamic object
// int does not have a Length property
// something = 12;

// storing a string in a dynamic object
// string has a Length property
// something = "Kauan";

// this compiles but might throw an exception at runtime
Console.WriteLine($"The Length of something is {something.Length}.");

// output the type of the something variable
Console.WriteLine($"The type of something is {something.GetType()}.");
printLine();
#endregion

#region var type
var population = 7_000_000_000; // var infers the type as int
var weight = 70.5; // var infers the type as double
var price = 4.99M; // var infers the type as decimal
var fruit = "Banana"; // var infers the type as string
var letter = 'A'; // var infers the type as char
var happy = true; // var infers the type as bool

// good use of var because it avois the repeated type
// as shown in the more verbose second statement
var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

// bad use of var because we cannot tell the type, so we
// should use a specific type declaration as shown in
// the second statement
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

printLine();
#endregion

#region default values
Console.WriteLine($"default(int) = {default(int)}"); // 0
Console.WriteLine($"default(bool) = {default(bool)}"); // False
Console.WriteLine($"default(DateTime) = {default(DateTime)}"); // 0001-01-01 00:00:00
Console.WriteLine($"default(string) = {default(string) ?? "<NULL>"}"); // null
printLine();

int number = 13;
Console.WriteLine($"number set to: {number}");
number = default;
Console.WriteLine($"number reset to its default: {number}");
printLine();
#endregion

#region positional arguments
// set current culture to US English so that all readers
// see the same output as shown in the book
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string formattedPrice = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

// three parameter values can use named arguments
Console.WriteLine("{0} {1} lived in {2}.",
    arg0: "Kauan", arg1: "Manzato", arg2: "São Paulo");

// four or more parameter values cannot use named arguments
Console.WriteLine(
    "{0} {1} lived in {2} and worked in the {3} team at {4}.",
    "Kauan", "Manzato", "São Paulo", "Development", "Manzato Tech");
printLine();
#endregion

#region interpolated strings
// the following statement must be all on one line when using C# 10
// or earlier. If using C# 11 or later, we can include a line break
// in the middle of an expression but not in the string text
Console.WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}.");
printLine();
#endregion

#region understanding format strings
string applesText = "Apples";
int applesCount = 1234;

string bananasText = "Bananas";
int bananasCount = 56789;

Console.WriteLine(format: "{0,-10} {1,6}",
    arg0: "Name", arg1: "Count");
Console.WriteLine(format: "{0,-10} {1,6:N0}",
    arg0: applesText, arg1: applesCount);
Console.WriteLine(format: "{0,-10} {1,6:N0}",
    arg0: bananasText, arg1: bananasCount);
printLine();
#endregion

#region custom number formatting
decimal value = 0.325M;
Console.WriteLine("Currency: {0:C}, Percentage: {0:0.0%}", value);
printLine();
#endregion