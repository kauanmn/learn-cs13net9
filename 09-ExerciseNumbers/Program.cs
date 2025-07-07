using Spectre.Console;

namespace _09_ExerciseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var table = new Table();

            // add columns
            table.AddColumn("Type");
            table.AddColumn("Byte(s) of memory");
            table.AddColumn("Min");
            table.AddColumn("Max");

            var typesArray = new Type[]
            {
                    typeof(sbyte),
                    typeof(byte),
                    typeof(short),
                    typeof(ushort),
                    typeof(int),
                    typeof(uint),
                    typeof(long),
                    typeof(ulong),
                    typeof(Int128),
                    typeof(UInt128),
                    typeof(Half),
                    typeof(float),
                    typeof(double),
                    typeof(decimal)
            };

            foreach (var type in typesArray)
            {
                // get the size of the type in bytes
                var size = System.Runtime.InteropServices.Marshal.SizeOf(type);
                // get the min and max values for the type
                var minField = type.GetField("MinValue");
                var maxField = type.GetField("MaxValue");

                var min = minField?.GetValue(null)?.ToString() ?? "N/A";
                var max = maxField?.GetValue(null)?.ToString() ?? "N/A";

                // add a row to the table
                table.AddRow(type.Name, size.ToString(), min, max);
            }

            // render the table to the console
            AnsiConsole.Write(table);
        }
    }
}
