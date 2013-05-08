using System.Reflection;

[assembly: AssemblyCompany("Milan Gardian")]
[assembly: AssemblyCopyright("Copyright (c) 2013 Milan Gardian. All rights reserved.")]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyProduct("Koboizer v1.0 "
#if DEBUG
    + "(debug)"
#else
    + "(release)"
#endif
)]

[assembly: AssemblyConfiguration(
#if DEBUG
    "DEBUG"
#else
    "RELEASE"
#endif
)]
