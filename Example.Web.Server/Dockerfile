FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["../Example.Web.Server/Example.Web.Server.csproj", "../Example.Web.Server/"]
RUN dotnet restore "../Example.Web.Server/Example.Web.Server.csproj"
COPY . .
WORKDIR "/src/../Example.Web.Server"
RUN dotnet build "Example.Web.Server.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Example.Web.Server.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Example.Web.Server.dll"]