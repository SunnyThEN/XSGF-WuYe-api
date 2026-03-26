#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
RUN apt-get update; apt-get install libfontconfig1 -y

WORKDIR /app
EXPOSE 9991

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MESTOP.WebApi/MESTOP.WebApi.csproj", "MESTOP.WebApi/"]
COPY ["MESTOP.System/MESTOP.Sys.csproj", "MESTOP.System/"]
COPY ["MESTOP.Core/MESTOP.Core.csproj", "MESTOP.Core/"]
COPY ["MESTOP.Entity/MESTOP.Entity.csproj", "MESTOP.Entity/"]
COPY ["MESTOP.Order/MESTOP.Order.csproj", "MESTOP.Order/"]
COPY ["MESTOP.AppManager/MESTOP.AppManager.csproj", "MESTOP.AppManager/"]
COPY ["MESTOP.Builder/MESTOP.Builder.csproj", "MESTOP.Builder/"]
RUN dotnet restore "MESTOP.WebApi/MESTOP.WebApi.csproj"
COPY . .
WORKDIR "/src/MESTOP.WebApi"
RUN dotnet build "MESTOP.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MESTOP.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MESTOP.WebApi.dll"]