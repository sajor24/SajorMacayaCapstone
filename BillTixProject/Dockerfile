# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy project files for restore
COPY ["BillTixWebApp/BillTixWebApp.csproj", "BillTixWebApp/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Framework/Framework.csproj", "Framework/"]

# Restore
RUN dotnet restore "BillTixWebApp/BillTixWebApp.csproj"

# Copy everything
COPY . .

# Publish
RUN dotnet publish "BillTixWebApp/BillTixWebApp.csproj" -c Release -o /app/publish --no-restore

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "BillTixWebApp.dll"]
