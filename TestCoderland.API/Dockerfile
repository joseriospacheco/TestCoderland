FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

COPY . . 

WORKDIR /app/TestCoderland.API

RUN dotnet restore TestCoderland.API.csproj

RUN dotnet tool install --global dotnet-ef

ENV PATH="$PATH:/root/.dotnet/tools"

RUN dotnet publish TestCoderland.API.csproj -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build-env /out . 
EXPOSE 5000

ENTRYPOINT ["dotnet", "TestCoderland.API.dll"]
