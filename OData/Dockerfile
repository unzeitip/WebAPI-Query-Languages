FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 22900

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OData/OData.csproj", "OData/"]
COPY ["Shared/Shared.csproj", "Shared/"]
RUN dotnet restore "OData/OData.csproj"
COPY . .
WORKDIR "/src/OData"
RUN dotnet build "OData.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OData.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OData.dll"]