using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var version = typeof(Program)
                .Assembly
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                .InformationalVersion;

            Console.WriteLine("Hello, world!");
            Console.WriteLine($"I am version {version}");
            Console.WriteLine($"My library is version {Class1.GetLibraryVersion()}");
        }
    }
}
