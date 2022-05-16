FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/TokenService.STS.Identity/TokenService.STS.Identity.csproj", "src/TokenService.STS.Identity/"]
COPY ["src/TokenService.Admin.EntityFramework.Shared/TokenService.Admin.EntityFramework.Shared.csproj", "src/TokenService.Admin.EntityFramework.Shared/"]
COPY ["src/TokenService.Shared/TokenService.Shared.csproj", "src/TokenService.Shared/"]
RUN dotnet restore "src/TokenService.STS.Identity/TokenService.STS.Identity.csproj"
COPY . .
WORKDIR "/src/src/TokenService.STS.Identity"
RUN dotnet build "TokenService.STS.Identity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TokenService.STS.Identity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "TokenService.STS.Identity.dll"]