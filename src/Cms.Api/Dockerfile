FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/Cms.Api/Cms.Api.csproj", "src/Cms.Api/"]
RUN dotnet restore "src/Cms.Api/Cms.Api.csproj"
COPY . .
WORKDIR "/src/src/Cms.Api"
RUN dotnet build "Cms.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Cms.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Cms.Api.dll"]