#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Presentation/Snippr.Site/Snippr.Site.csproj", "src/Presentation/Snippr.Site/"]
RUN dotnet restore "src/Presentation/Snippr.Site/Snippr.Site.csproj"
COPY . .
WORKDIR "/src/src/Presentation/Snippr.Site"
RUN dotnet build "Snippr.Site.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Snippr.Site.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Snippr.Site.dll"]