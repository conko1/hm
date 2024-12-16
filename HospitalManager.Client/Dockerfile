FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5123

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY ./HospitalManager.Client/ ./
COPY ./HospitalManager.Shared/ ../HospitalManager.Shared/

RUN dotnet tool install --global dotnet-ef
ENV PATH="${PATH}:/root/.dotnet/tools"

ENTRYPOINT ["dotnet", "watch", "run", "--urls=http://+:5123", "--no-hot-reload"]