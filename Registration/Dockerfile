FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/Application/Registration.API/Registration.API.csproj", "src/Application/Registration.API/"]
COPY ["src/Service/Registration.DependencyInjection/Registration.DependencyInjection.csproj", "src/Service/Registration.DependencyInjection/"]
COPY ["src/Domain/Registration.CentralPackages/Registration.CentralPackages.csproj", "src/Domain/Registration.CentralPackages/"]
COPY ["src/Domain/Registration.DomainCore/Registration.DomainCore.csproj", "src/Domain/Registration.DomainCore/"]
COPY ["src/Domain/Registration.DomainBase/Registration.DomainBase.csproj", "src/Domain/Registration.DomainBase/"]
COPY ["src/Service/Registration.Handlers/Registration.Handlers.csproj", "src/Service/Registration.Handlers/"]
COPY ["src/Repository/Registration.Repository/Registration.Repository.csproj", "src/Repository/Registration.Repository/"]
COPY ["src/Infrastructure/Registration.Resources/Registration.Resources.csproj", "src/Infrastructure/Registration.Resources/"]
COPY ["src/Service/Registration.Mapper/Registration.Mapper.csproj", "src/Service/Registration.Mapper/"]
COPY ["src/Service/MessageBroker/MessageBroker.csproj", "src/Service/MessageBroker/"]
COPY ["src/Infrastructure/Registration.Infrastructure/Registration.Infrastructure.csproj", "src/Infrastructure/Registration.Infrastructure/"]
COPY ["src/Service/CloudServices/CloudServices.csproj", "src/Service/CloudServices/"]
RUN dotnet restore "src/Application/Registration.API/Registration.API.csproj"

COPY . .
WORKDIR "/src/src/Application/Registration.API"
RUN dotnet build "Registration.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Registration.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Registration.API.dll"]