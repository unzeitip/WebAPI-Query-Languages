FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 26846

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["JsonApi/JsonApi.csproj", "JsonApi/"]
COPY ["Shared/Shared.csproj", "Shared/"]
RUN dotnet restore "JsonApi/JsonApi.csproj"
COPY . .
WORKDIR "/src/JsonApi"
RUN dotnet build "JsonApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JsonApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JsonApi.dll"]