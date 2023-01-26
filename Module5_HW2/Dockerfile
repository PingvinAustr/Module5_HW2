#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Module5_HW2/Module5_HW2.csproj", "Module5_HW2/"]
RUN dotnet restore "Module5_HW2/Module5_HW2.csproj"
COPY . .
WORKDIR "/src/Module5_HW2"
RUN dotnet build "Module5_HW2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Module5_HW2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Module5_HW2.dll"]