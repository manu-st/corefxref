# Description

CoreFX Ref is providing the bare minimum setup to let you compile an existing VisualStudio project against the CoreCLR/CoreFX target.

It provides the set of MSBuild rules and reference assemblies which can be used in your VisualStudio project to compile it against CoreCLR/CoreFX.

# Usage

To use this, update your project to import configs\CoreCLR.CSharp.targets instead of the default config which is usually one of **$(MSBuildToolsPath)\Microsoft.CSharp.targets** or **$(MSBuildExtensionsPath32)\Microsoft\Portable\$(TargetFrameworkVersion)\Microsoft.Portable.CSharp.targets**.

In addition make sure to define the following properties **TargetFrameworkRootPath** and **FrameworkPathOverride** to point where you checked out CoreFX Ref.

For example, if you have checked out the code in **C:\CoreFX**, then you should add:
```
  <TargetFrameworkRootPath>C:\CoreFX</TargetFrameworkRootPath>
  <FrameworkPathOverride>C:\CoreFX\CoreCLR\v5.0</FrameworkPathOverride>
```

# Area of improvements

* Avoid the need to override Microsoft supplied MSBuild configurations.
