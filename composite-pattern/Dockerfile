FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["composite-pattern/composite-pattern.csproj", "composite-pattern/"]
RUN dotnet restore "composite-pattern/composite-pattern.csproj"
COPY . .
WORKDIR "/src/composite-pattern"
RUN dotnet build "composite-pattern.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "composite-pattern.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "composite-pattern.dll"]
