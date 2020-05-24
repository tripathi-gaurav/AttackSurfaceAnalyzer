# escape=`
FROM mcr.microsoft.com/windows:3.1-nanoserver-1909 

COPY Detonate.ps1 C:\Detonate.ps1

RUN dotnet tool install -g --add-source ../Path.To.nupkg Microsoft.CST.AttackSurfaceAnalyzer.CLI

ENTRYPOINT ["powershell", "Set-ExecutionPolicy Bypass -Scope Process -Force; C:\\Detonate.ps1"]