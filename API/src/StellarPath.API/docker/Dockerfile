FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081	

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["API/API.csproj", "API/"]
COPY ["StellarPath.API.Core/StellarPath.API.Core.csproj", "StellarPath.API.Core/"]
COPY ["StelarPath.Infrastructure/StelarPath.API.Infrastructure.csproj", "StelarPath.Infrastructure/"]
RUN dotnet restore "API/API.csproj"

COPY . .
WORKDIR "/src/API"
RUN dotnet build "API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API.dll"]