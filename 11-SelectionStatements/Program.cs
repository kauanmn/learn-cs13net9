void printLine()
{
    WriteLine("\n----------------------------------------\n");
}

#region branching with the if statement

string password = "ninja";

if (password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 chars.");
}
else
{
    WriteLine("Your password is strong.");
}

#endregion