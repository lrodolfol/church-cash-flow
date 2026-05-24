ARG BUILD_CONFIGURATION=Release

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["Registration/src/Application/Registration.API/Registration.API.csproj", "Registration/src/Application/Registration.API/"]
COPY ["Registration/src/Service/Registration.DependencyInjection/Registration.DependencyInjection.csproj", "Registration/src/Service/Registration.DependencyInjection/"]
COPY ["Registration/src/Domain/Registration.CentralPackages/Registration.CentralPackages.csproj", "Registration/src/Domain/Registration.CentralPackages/"]
COPY ["Registration/src/Domain/Registration.DomainCore/Registration.DomainCore.csproj", "Registration/src/Domain/Registration.DomainCore/"]
COPY ["Registration/src/Domain/Registration.DomainBase/Registration.DomainBase.csproj", "Registration/src/Domain/Registration.DomainBase/"]
COPY ["Registration/src/Service/Registration.Handlers/Registration.Handlers.csproj", "Registration/src/Service/Registration.Handlers/"]
COPY ["Registration/src/Repository/Registration.Repository/Registration.Repository.csproj", "Registration/src/Repository/Registration.Repository/"]
COPY ["Registration/src/Infrastructure/Registration.Resources/Registration.Resources.csproj", "Registration/src/Infrastructure/Registration.Resources/"]
COPY ["Registration/src/Service/Registration.Mapper/Registration.Mapper.csproj", "Registration/src/Service/Registration.Mapper/"]
COPY ["Registration/src/Service/MessageBroker/MessageBroker.csproj", "Registration/src/Service/MessageBroker/"]
COPY ["Registration/src/Infrastructure/Registration.Infrastructure/Registration.Infrastructure.csproj", "Registration/src/Infrastructure/Registration.Infrastructure/"]
COPY ["Registration/src/Service/CloudServices/CloudServices.csproj", "Registration/src/Service/CloudServices/"]
COPY ["Registration/src/Test/HandlerTest/HandlersTest.csproj", "Registration/src/Test/HandlersTest/"]
COPY . .

RUN dotnet restore "Registration/Registration.sln"

RUN dotnet build "Registration/src/Application/Registration.API/Registration.API.csproj" -c Release -o /app/build

FROM build AS sonar
ARG SONAR_PROJECT_ID=church-key-sonar
ARG SONAR_HOST_URL=http://host.docker.internal:9000

RUN apt-get update && apt-get install -y default-jdk-headless && rm -rf /var/lib/apt/lists/*
RUN dotnet tool install --global dotnet-sonarscanner
ENV PATH="${PATH}:/root/.dotnet/tools"

RUN --mount=type=secret,id=sonar_token \
    dotnet sonarscanner begin \
    /k:${SONAR_PROJECT_ID} \
    /d:sonar.host.url=${SONAR_HOST_URL} \
    /d:sonar.login=$(cat /run/secrets/sonar_token)

RUN dotnet build "Registration/Registration.sln" --no-restore

RUN --mount=type=secret,id=sonar_token \
    dotnet sonarscanner end /d:sonar.login=$(cat /run/secrets/sonar_token)

FROM sonar AS publish
WORKDIR /src
RUN dotnet publish "Registration/src/Application/Registration.API/Registration.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Registration.API.dll"]
