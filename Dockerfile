# 1. Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY *.sln .

COPY MarketDataApi.Api/*.csproj ./MarketDataApi.Api/
COPY MarketDataApi.Application/*.csproj ./MarketDataApi.Application/
COPY MarketDataApi.Domain/*.csproj ./MarketDataApi.Domain/
COPY MarketDataApi.Infrastructure/*.csproj ./MarketDataApi.Infrastructure/

RUN dotnet restore

COPY . .

WORKDIR /src/MarketDataApi.Api
RUN dotnet publish -c Release -o /app/publish

# 2. Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "MarketDataApi.Api.dll"]