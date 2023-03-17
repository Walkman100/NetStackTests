using System;

namespace CSharpConsoleNetCore3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Shared.GetFrameworkVersion());
            Console.WriteLine(Environment.OSVersion.ToString());
            Shared.WriteCompileTests();
        }
    }
}
