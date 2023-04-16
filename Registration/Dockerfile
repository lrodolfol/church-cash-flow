FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

COPY ["../src/Registration.API/Registration.API.csproj", "Registration.API/"]
COPY ../src/ . ./

COPY ["../src/Registration.DomainBase/Registration.DomainBase.csproj", "Registration.DomainBase/"]

COPY ["../src/Registration.DomainCore/Registration.DomainCore.csproj", "Registration.DomainCore/"]

COPY ["../src/Registration.Handlers/Registration.Handlers.csproj", "Registration.Handlers/"]

COPY ["../src/Registration.Infrastructure/Registration.Infrastructure.csproj", "Registration.Infrastructure/"]

COPY ["../src/Registration.Mapper/Registration.Mapper.csproj", "Registration.Mapper/"]

COPY ["../src/Registration.Repository/Registration.Repository.csproj", "Registration.Repository/"]

WORKDIR "/src/Registration.API"
RUN dotnet build "Registration.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Registration.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Registration.API.dll"]