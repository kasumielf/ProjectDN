FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY ProjectDNMain/ProjectDNMain.csproj ProjectDNMain/
RUN dotnet restore ProjectDNMain/ProjectDNMain.csproj
COPY . .
WORKDIR /src/ProjectDNMain
RUN dotnet build ProjectDNMain.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ProjectDNMain.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ProjectDNMain.dll"]
