using System;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace ConsoleTestRoslyn
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Console.WriteLine(\"Hello, World!\");";
            var script = CSharpScript.Create(text, ScriptOptions.Default.AddImports("System"));
            var result = script.RunAsync();

            Console.ReadKey();
        }
    }
}
