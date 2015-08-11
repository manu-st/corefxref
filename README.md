CoreFX Ref is providing the bare minimum setup to let you compile an existing VisualStudio project against the CoreCLR/CoreFX target.

It provides the set of MSBuild rules and reference assemblies which can be used in your VisualStudio project to compile it against CoreCLR/CoreFX.

To use this, update your project to import configs\Microsoft.Portable.CSharp.targets instead of either of the following default ''$(MSBuildToolsPath)\Microsoft.CSharp.targets'' or ''$(MSBuildExtensionsPath32)\Microsoft\Portable\$(TargetFrameworkVersion)\Microsoft.Port''.

