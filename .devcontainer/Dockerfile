# Use the official Microsoft .NET development container image
FROM mcr.microsoft.com/devcontainers/dotnet:7.0

# Configure apt, install packages and dotnet global tools
RUN apt-get update \
    && apt-get install -y --no-install-recommends postgresql-client \
    # Install the EF Core CLI tool globally
    && dotnet tool install --global dotnet-ef \
    # Clean up
    && apt-get clean -y \
    && rm -rf /var/lib/apt/lists/*
