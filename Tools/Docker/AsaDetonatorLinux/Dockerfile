FROM mcr.microsoft.com/dotnet/core/sdk:3.1

COPY Detonate.sh /Detonate.sh

RUN dotnet tool install -g --add-source ../Path.To.nupkg Microsoft.CST.AttackSurfaceAnalyzer.CLI

# Required for Port collector
RUN apt-get update && apt-get install -y \
    coreutils \
    iproute2

ENTRYPOINT ["sh", "/Detonate.sh"]