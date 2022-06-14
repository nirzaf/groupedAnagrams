FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["StringB/StringB.csproj", "StringB/"]
RUN dotnet restore "StringB/StringB.csproj"
COPY . .
WORKDIR "/src/StringB"
RUN dotnet build "StringB.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StringB.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StringB.dll"]
