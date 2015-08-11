rm -f CoreCLR.Helpers.dll
"c:\Program Files (x86)\MSBuild\14.0\Bin\csc.exe"  /noconfig /nowarn:1701,1702 /nostdlib+ /target:library /out:CoreCLR.Helpers.dll /r:..\System.Runtime.dll /r:..\System.IO.dll /r:..\System.Security.Cryptography.X509Certificates.dll /r:..\System.Net.Primitives.dll /r:..\System.Reflection.dll /keyfile:signing.key *.cs
mv CoreCLR.Helpers.dll ..
