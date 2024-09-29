@echo off

dotnet build --configuration Release
dotnet pack
set /p Version=Version: 
nuget push ".\s2clientprotocol.NET\bin\Release\s2clientprotocol.NET.%Version%.nupkg" -SkipDuplicate -NonInteractive
pause