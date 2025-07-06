using System.Globalization;

Action printLine = () =>
    WriteLine("\n----------------------------------------------------------\n");

#region positional arguments
// set current culture to US English so that all readers
// see the same output as shown in the book
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string formattedPrice = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

// three parameter values can use named arguments
WriteLine("{0} {1} lived in {2}.",
    arg0: "Kauan", arg1: "Manzato", arg2: "São Paulo");

// four or more parameter values cannot use named arguments
WriteLine(
    "{0} {1} lived in {2} and worked in the {3} team at {4}.",
    "Kauan", "Manzato", "São Paulo", "Development", "Manzato Tech");
printLine();
#endregion

#region interpolated strings
// the following statement must be all on one line when using C# 10
// or earlier. If using C# 11 or later, we can include a line break
// in the middle of an expression but not in the string text
WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}.");
printLine();
#endregion

#region understanding format strings
string applesText = "Apples";
int applesCount = 1234;

string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine(format: "{0,-10} {1,6}",
    arg0: "Name", arg1: "Count");
WriteLine(format: "{0,-10} {1,6:N0}",
    arg0: applesText, arg1: applesCount);
WriteLine(format: "{0,-10} {1,6:N0}",
    arg0: bananasText, arg1: bananasCount);
printLine();
#endregion

#region custom number formatting
decimal value = 0.325M;
WriteLine("Currency: {0:C}, Percentage: {0:0.0%}", value);
printLine();
#endregion

//#region user input
//Write("Type your first name and press ENTER: ");
//string? firstName = ReadLine();

//Write("Type your age and press ENTER: ");
//string age = ReadLine()!;

//WriteLine($"Hello, {firstName}, you look good for {age}.");
//printLine();
//#endregion

#region getting key input from user
Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);
printLine();
#endregion