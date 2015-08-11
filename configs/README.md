To make MSBuild happy we had to tweak a few Microsoft supplied configuration files. Using a standard installation of Visual Studio 2015, the files you see here are copies of what you will find at:

1. C:\Program Files (x86)\MSBuild\Microsoft\Portable\Microsoft.Portable.Core.props
2. C:\Program Files (x86)\MSBuild\Microsoft\Portable\Microsoft.Portable.Core.targets
3. C:\Program Files (x86)\MSBuild\Microsoft\Portable\v4.6\Microsoft.Portable.Common.targets
4. C:\Program Files (x86)\MSBuild\Microsoft\Portable\v4.6\Microsoft.Portable.CSharp.targets

with the following changes:

1. Microsoft.Portable.Core.targets was modified to not report an error if we do not specify a profile via TargetFrameworkProfile as building the layout that Microsoft expects when you are using a profile is not obvious and did not want to spend too much time on that.

2. Microsoft.Portable.Core.props was modified to use different names for the TargetPlatformIdentifier, TargetFrameworkIdentifier and TargetFrameworkMonikerDisplayName. In addition, we have hardcoded the version number (we only have one for now, v5.0), added the NoStdLib option to not look for mscorlib.dll.

3. The files from the 4.6 subdirectories were modified to just change the location of the above 2 Microsoft.Portable.Core.xxx files which are now all in the same folder.

If you find a proper way to set this up without having to modify the Microsoft supplied MS Build, feel free to send a pull request.
