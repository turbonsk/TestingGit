FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 65396
EXPOSE 44378

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["TestServiceAPI/TestServiceAPI.csproj", "TestServiceAPI/"]
RUN dotnet restore "TestServiceAPI/TestServiceAPI.csproj"
COPY . .
WORKDIR "/src/TestServiceAPI"
RUN dotnet build "TestServiceAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TestServiceAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TestServiceAPI.dll"]