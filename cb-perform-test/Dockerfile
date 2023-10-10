#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["cb-perform-test/cb-perform-test.csproj", "cb-perform-test/"]
RUN dotnet restore "cb-perform-test/cb-perform-test.csproj"
COPY . .
WORKDIR "/src/cb-perform-test"
RUN dotnet build "cb-perform-test.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cb-perform-test.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cb-perform-test.dll"]