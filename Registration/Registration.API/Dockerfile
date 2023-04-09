FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Registration.API/Registration.API.csproj", "Registration.API/"]
RUN dotnet restore "Registration.API/Registration.API.csproj"
COPY . .
WORKDIR "/src/Registration.API"
RUN dotnet build "Registration.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Registration.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Registration.API.dll"]