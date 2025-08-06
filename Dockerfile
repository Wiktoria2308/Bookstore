# FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
# WORKDIR /app

# COPY BokmalensWebbshop.csproj ./
# RUN dotnet restore BokmalensWebbshop.csproj

# COPY . ./
# RUN dotnet publish BokmalensWebbshop.csproj -c Release -o out

# RUN ls -l /app/out

# FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
# WORKDIR /app

# COPY --from=build /app/out/. ./

# RUN ls -l /app

# ENTRYPOINT ["dotnet", "BokmalensWebbshop.dll"]


FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /app

# Instalacja dotnet-watch do hot reload
RUN dotnet tool install --global dotnet-watch
ENV PATH="$PATH:/root/.dotnet/tools"

EXPOSE 8080

# ENTRYPOINT uruchamiający dotnet watch run na porcie 8080
ENTRYPOINT ["dotnet", "watch", "run", "--urls=http://+:8080"]

