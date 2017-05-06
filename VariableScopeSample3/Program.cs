using static System.Console;

namespace Wrox
{
    class Program
    {
        static int j = 20;
        static int Main(string[] args)
        {
            int j = 30;
            WriteLine(j);
            WriteLine(Program.j);
            return 0;
        }
    }
}