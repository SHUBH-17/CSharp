// installation and setup
//---------------------------------------------------------------------------------------------------------------------//
Gacutil /I "C:\Users\Dell-PC\.nuget\packages\npoi\2.5.6\lib\net45\NPOI.OOXML.dll"
Gacutil /I "C:\Users\Dell-PC\.nuget\packages\npoi\2.5.6\lib\net45\NPOI.OpenXml4Net.dll"
Gacutil /I "C:\Users\Dell-PC\.nuget\packages\npoi\2.5.6\lib\net45\NPOI.OpenXmlFormats.dll"
Gacutil /I "C:\Users\Dell-PC\.nuget\packages\npoi\2.5.6\lib\netstandard2.1\NPOI.dll"
Gacutil /I "C:\Users\Dell-PC\.nuget\packages\npoi\2.5.6\lib\netstandard2.1\NPOI.OOXML.dll"
Gacutil /I "C:\Users\Dell-PC\.nuget\packages\npoi\2.5.6\lib\netstandard2.1\NPOI.OpenXml4Net.dll"
Gacutil /I "C:\Users\Dell-PC\.nuget\packages\npoi\2.5.6\lib\netstandard2.1\NPOI.OpenXmlFormats.dll"
Gacutil /I "C:\Users\Dell-PC\.nuget\packages\npoi\2.5.6\lib\netstandard2.0\NPOI.dll"
Gacutil /I "C:\Users\Dell-PC\.nuget\packages\npoi\2.5.6\lib\netstandard2.0\NPOI.OOXML.dll"
Gacutil /I "C:\Users\Dell-PC\.nuget\packages\npoi\2.5.6\lib\netstandard2.0\NPOI.OpenXml4Net.dll"
Gacutil /I "C:\Users\Dell-PC\.nuget\packages\npoi\2.5.6\lib\netstandard2.0\NPOI.OpenXmlFormats.dll"
Gacutil /I "C:\Users\Dell-PC\.nuget\packages\npoi\2.5.6\lib\net45\NPOI.dll"


Gacutil /I "C:\Users\Dell-PC\.nuget\packages\portable.bouncycastle\1.8.9\lib\net40\BouncyCastle.Crypto.dll"
Gacutil /I "C:\Users\Dell-PC\.nuget\packages\portable.bouncycastle\1.8.9\lib\netstandard2.0\BouncyCastle.Crypto.dll"

Gacutil /I "C:\Users\Dell-PC\.nuget\packages\sharpziplib\1.3.3\lib\net45\ICSharpCode.SharpZipLib.dll"
Gacutil /I "C:\Users\Dell-PC\.nuget\packages\sharpziplib\1.3.3\lib\netstandard2.1\ICSharpCode.SharpZipLib.dll"
Gacutil /I "C:\Users\Dell-PC\.nuget\packages\sharpziplib\1.3.3\lib\netstandard2.0\ICSharpCode.SharpZipLib.dll"

//---------------------------------------------------------------------------------------------------------------------//

#Keep the .NET Framework to latest version (ex.4.7) of the script/package/program.

//---------------------------------------------------------------------------------------------------------------------//

#open nuget package manager console and install the package
install-package NPOI
#or
install-package NPOI -version 2.5.6

//---------------------------------------------------------------------------------------------------------------------//

