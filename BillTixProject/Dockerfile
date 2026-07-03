# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy solution and all project files first (for layer caching)
COPY BillTixProject.slnx .
COPY BillTixWebApp/BillTixWebApp.csproj BillTixWebApp/
COPY Domain/Domain.csproj Domain/
COPY Framework/Framework.csproj Framework/

# Restore dependencies
RUN dotnet restore BillTixWebApp/BillTixWebApp.csproj

# Copy all source files
COPY BillTixWebApp/ BillTixWebApp/
COPY Domain/ Domain/
COPY Framework/ Framework/

# Build and publish
WORKDIR /src/BillTixWebApp
RUN dotnet publish -c Release -o /app/out --no-restore

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "BillTixWebApp.dll"]
