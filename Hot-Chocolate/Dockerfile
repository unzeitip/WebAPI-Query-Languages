FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 36976

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Hot-Chocolate/Hot-Chocolate.csproj", "Hot-Chocolate/"]
COPY ["Shared/Shared.csproj", "Shared/"]
RUN dotnet restore "Hot-Chocolate/Hot-Chocolate.csproj"
COPY . .
WORKDIR "/src/Hot-Chocolate"
RUN dotnet build "Hot-Chocolate.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hot-Chocolate.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hot-Chocolate.dll"]