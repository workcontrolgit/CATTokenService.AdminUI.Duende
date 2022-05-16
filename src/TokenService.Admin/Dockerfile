FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/TokenService.Admin/TokenService.Admin.csproj", "src/TokenService.Admin/"]
COPY ["src/TokenService.Admin.EntityFramework.Shared/TokenService.Admin.EntityFramework.Shared.csproj", "src/TokenService.Admin.EntityFramework.Shared/"]
COPY ["src/TokenService.Admin.EntityFramework.SqlServer/TokenService.Admin.EntityFramework.SqlServer.csproj", "src/TokenService.Admin.EntityFramework.SqlServer/"]
COPY ["src/TokenService.Shared/TokenService.Shared.csproj", "src/TokenService.Shared/"]
COPY ["src/TokenService.Admin.EntityFramework.PostgreSQL/TokenService.Admin.EntityFramework.PostgreSQL.csproj", "src/TokenService.Admin.EntityFramework.PostgreSQL/"]
COPY ["src/TokenService.Admin.EntityFramework.MySql/TokenService.Admin.EntityFramework.MySql.csproj", "src/TokenService.Admin.EntityFramework.MySql/"]
RUN dotnet restore "src/TokenService.Admin/TokenService.Admin.csproj"
COPY . .
WORKDIR "/src/src/TokenService.Admin"
RUN dotnet build "TokenService.Admin.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TokenService.Admin.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "TokenService.Admin.dll"]