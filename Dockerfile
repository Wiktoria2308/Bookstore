

# FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
# WORKDIR /app

# # Instalacja dotnet-watch do hot reload
# RUN dotnet tool install --global dotnet-watch
# ENV PATH="$PATH:/root/.dotnet/tools"

# EXPOSE 8080

# # ENTRYPOINT uruchamiający dotnet watch run na porcie 8080
# ENTRYPOINT ["dotnet", "watch", "run", "--urls=http://+:8080"]


FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app

RUN dotnet tool install --global dotnet-watch
ENV PATH="$PATH:/root/.dotnet/tools"

EXPOSE 8080

COPY *.csproj ./
RUN dotnet restore
COPY . .

CMD ["dotnet", "watch", "run", "--urls=http://+:8080"]