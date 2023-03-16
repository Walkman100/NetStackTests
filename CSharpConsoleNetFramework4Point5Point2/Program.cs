using System;

namespace CSharpConsoleNetFramework4Point5Point2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Shared.GetFrameworkVersion());
            Console.WriteLine(Environment.OSVersion.ToString());
#if NETCOREAPP
            Console.WriteLine("NetCore");
#endif
#if NET
            Console.WriteLine("Net??");
#endif
#if NETCOREAPP1_0_OR_GREATER
            Console.WriteLine("NetCore 1.0+");
#endif
#if NETCOREAPP1_1_OR_GREATER
            Console.WriteLine("NetCore 1.1+");
#endif
#if NETCOREAPP2_0_OR_GREATER
            Console.WriteLine("NetCore 2.0+");
#endif
#if NETCOREAPP2_1_OR_GREATER
            Console.WriteLine("NetCore 2.1+");
#endif
#if NETCOREAPP2_2_OR_GREATER
            Console.WriteLine("NetCore 2.2+");
#endif
#if NETCOREAPP3_0_OR_GREATER
            Console.WriteLine("NetCore 3.0+");
#endif
#if NETCOREAPP3_1_OR_GREATER
            Console.WriteLine("NetCore 3.1+");
#endif
#if NET5_0
            Console.WriteLine("NetCore 5.0");
#endif
#if NET5_0_OR_GREATER
            Console.WriteLine("NetCore 5.0+");
#endif
        }
    }
}
