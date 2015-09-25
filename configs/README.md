To make MSBuild happy we supply our own version of the Portable C# targets. It is a copy of the Microsoft supplied one at "C:\Program Files (x86)\MSBuild\Microsoft\Portable\v5.0\Microsoft.Portable.CSharp.targets" where we added in addition to the existing imports some definitions for identifying our .NET target, and we overrided "\_CheckForInvalidTargetFrameworkProfile" to not do anything since we do not have a profile.

Note that before including Microsoft.Portable.Common.targets we define the Framework version to 4.6, as the 5.0 folder from Microsoft is empty and would not include our assemblies. After inclusion, we update the version to 5.0 as we expect.

If you find a better way to set this up without having to copy the Microsoft supplied MS Build targets, feel free to send a pull request.
