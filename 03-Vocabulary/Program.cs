// See https://aka.ms/new-console-template for more information
// #error version
// Console.WriteLine("Hello, World!");
// WriteLine($"Computer named {Env.MachineName} says \"No.\"");

using System.Reflection;

// declare some unused variables using types in
// additional assemblies to make them load too
System.Data.DataSet ds = new();
HttpClient client = new();

// get the assembly that is the entry point for this app
Assembly? myApp = Assembly.GetEntryAssembly();

// if the previous line returned nothing, then end the app
if (myApp is null) return;

// loop through the assemblies that my app references
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    // load the assembly so we can read its details
    Assembly a = Assembly.Load(name);

    // declare a variable to count the number of methods
    int methodCount = 0;

    foreach (TypeInfo t in a.DefinedTypes)
    {
        // add up the counts of all the methods
        methodCount += t.GetMethods().Length;
    }

    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name);
}

