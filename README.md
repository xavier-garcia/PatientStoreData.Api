# Patient Data Store
POC of an Api with Swagger, Authentification

### How to generate database
From Package manager console:
```sh
> cd directorio api ".\src\StoreDataApi\src"
> dotnet ef migrations add [NombreMigracion]
> dotnet ef database update => para develop
> dotnet ef migrations script <LastMigrationApplied> 
(where LastMigrationApplied in SELECT "MigrationId" FROM public."__EFMigrationsHistory" order by "MigrationId" desc limit 1;)
```
