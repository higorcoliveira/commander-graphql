# commander-graphql
A complete API in graphQL using hot chocolate.

## How to run

You must have installed .NET 5 and docker 

Then, run the following commands:

```
docker-compose up -d
dotnet build
dotnet run
```

## How to add a migration:

You must install dotnet-ef:

```
dotnet tool install --global dotnet-ef
```

Then run: 

```
dotnet ef migrations add AddPlatformToDB
```
