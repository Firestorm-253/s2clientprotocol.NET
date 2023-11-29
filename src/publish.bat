dotnet build
dotnet pack
set /p Version=Version: 
dotnet nuget push "s2clientprotocol.NET\bin\Release\s2clientprotocol.NET.%Version%.nupkg"