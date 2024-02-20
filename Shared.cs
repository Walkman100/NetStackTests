using System;

public static class Shared {
    public static Version GetFrameworkVersion() {
        var frameworkName = new System.Runtime.Versioning.FrameworkName(AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName);
        return frameworkName.Version;
    }

    public static void WriteCompileTests() {
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
#if NET6_0
        Console.WriteLine("NetCore 6.0");
#endif
#if NET6_0_OR_GREATER
        Console.WriteLine("NetCore 6.0+");
#endif
#if NET7_0
        Console.WriteLine("NetCore 7.0");
#endif
#if NET7_0_OR_GREATER
        Console.WriteLine("NetCore 7.0+");
#endif
#if NET8_0
        Console.WriteLine("NetCore 8.0");
#endif
#if NET8_0_OR_GREATER
        Console.WriteLine("NetCore 8.0+");
#endif
    }
}
