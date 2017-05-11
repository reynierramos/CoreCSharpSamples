using static System.Console;

namespace Wrox
{
    class Program
    {
        static void Main(string[] args)
        {
            // This loop iterates through rows
            for (int i = 0; i < 100; i+=10)
            {
                // This loop iterates through columns
                for (int j = i; j < i + 10; j++)
                {
                    Write($" {j}");
                }
                WriteLine();
            }
        }
    }
}