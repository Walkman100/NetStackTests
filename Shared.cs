using System;

public static class Shared {
    public static Version GetFrameworkVersion() {
        var frameworkName = new System.Runtime.Versioning.FrameworkName(AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName);
        return frameworkName.Version;
    }
}
