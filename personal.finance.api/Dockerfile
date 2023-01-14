#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["personal.finance.api/personal.finance.api.fsproj", "personal.finance.api/"]
RUN dotnet restore "personal.finance.api/personal.finance.api.fsproj"
COPY . .
WORKDIR "/src/personal.finance.api"
RUN dotnet build "personal.finance.api.fsproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "personal.finance.api.fsproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "personal.finance.api.dll"]