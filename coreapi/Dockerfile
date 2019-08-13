FROM mcr.microsoft.com/dotnet/core/aspnet:3.0.0-preview6 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0.100-preview6 AS build
WORKDIR /src
COPY ["coreapi.csproj", "./"]
RUN dotnet restore "./coreapi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "coreapi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "coreapi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "coreapi.dll"]
