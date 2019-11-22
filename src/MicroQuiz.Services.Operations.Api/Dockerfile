FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["MicroQuiz.Services.Operations.Api/MicroQuiz.Services.Operations.Api.csproj", "MicroQuiz.Services.Operations.Api/"]
RUN dotnet restore "MicroQuiz.Services.Operations.Api/MicroQuiz.Services.Operations.Api.csproj"
COPY . .
WORKDIR "/src/MicroQuiz.Services.Operations.Api"
RUN dotnet build "MicroQuiz.Services.Operations.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroQuiz.Services.Operations.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroQuiz.Services.Operations.Api.dll"]