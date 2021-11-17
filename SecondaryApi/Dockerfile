#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["SecondaryApi/SecondaryApi.csproj", "SecondaryApi/"]
COPY ["MyLibrary/MyLibrary.csproj", "MyLibrary/"]
RUN dotnet restore "SecondaryApi/SecondaryApi.csproj"
COPY . .
WORKDIR "/src/SecondaryApi"
RUN dotnet build "SecondaryApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SecondaryApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SecondaryApi.dll"]
