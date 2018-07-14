FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY ProjectDN/ProjectDN.csproj ProjectDN/
RUN dotnet restore ProjectDN/ProjectDN.csproj
COPY . .
WORKDIR /src/ProjectDN
RUN dotnet build ProjectDN.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ProjectDN.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ProjectDN.dll"]
