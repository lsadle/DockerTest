#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["MainProject/MainProject.csproj", "MainProject/"]
COPY ["MyLibrary/MyLibrary.csproj", "MyLibrary/"]
RUN dotnet restore "MainProject/MainProject.csproj"
COPY . .
WORKDIR "/src/MainProject"
RUN dotnet build "MainProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MainProject.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MainProject.dll"]
