using System.Xml;

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