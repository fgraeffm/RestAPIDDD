FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
EXPOSE 80
EXPOSE 443
EXPOSE 4960
COPY --from=build-env /app/RestAPIDDD.API/out .
ENTRYPOINT ["dotnet", "RestAPIDDD.API.dll"]



