# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy project files
COPY ["BillTixProject/BillTixWebApp/BillTixWebApp.csproj", "BillTixProject/BillTixWebApp/"]
COPY ["BillTixProject/Domain/Domain.csproj", "BillTixProject/Domain/"]
COPY ["BillTixProject/Framework/Framework.csproj", "BillTixProject/Framework/"]

# Restore dependencies
RUN dotnet restore "BillTixProject/BillTixWebApp/BillTixWebApp.csproj"

# Copy everything else
COPY . .

# Build and publish
WORKDIR "/src/BillTixProject/BillTixWebApp"
RUN dotnet publish "BillTixWebApp.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "BillTixWebApp.dll"]
