using Introduction = Wrox.ProCSharp.Basics;
using static System.Console;

namespace NamespaceSample
{
    class Program
    {
        static void Main()
        {
            Introduction::NamespaceSample NSEx =
                new Introduction::NamespaceSample();
            WriteLine(NSEx.GetNamespase());
        }
    }
}

namespace Wrox.ProCSharp.Basics
{
    class NamespaceSample
    {
        public string GetNamespase()
        {
            return this.GetType().Namespace;
        }
    }
}