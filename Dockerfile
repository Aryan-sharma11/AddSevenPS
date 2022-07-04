FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0  AS build
WORKDIR /src
COPY ["AddSevenPS/AddSevenPS/AddSevenPS.fsproj", "AddSevnPS/"]
RUN dotnet restore "AddSevenPS/AddSevenPS.fsproj"
COPY . .
WORKDIR "/src/AddSevenPS"
RUN dotnet build "AddSevenPS.fsproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AddSevenPS.fsproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AddSevenPS.dll"]
