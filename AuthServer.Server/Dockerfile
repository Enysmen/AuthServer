FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["AuthServer.Server/AuthServer.Server.csproj","AuthServer.Server/"]
RUN dotnet restore "AuthServer.Server/AuthServer.Server.csproj" -p:BuildClient=false

COPY AuthServer.Server/ AuthServer.Server/
RUN dotnet publish "AuthServer.Server/AuthServer.Server.csproj" -c Release -p:BuildClient=false --no-restore -o /app/publish

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS final
WORKDIR /app

COPY --from=build /app/publish/ ./
ENV ASPNETCORE_HTTP_PORTS=8080
EXPOSE 8080
USER app


ENTRYPOINT ["dotnet","AuthServer.Server.dll"]