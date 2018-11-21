# ApiRestNetCore2x
C#, .NetCore, Entity Framework, Swagger , JWT.io


dotnet ef migrations add InitialCreate

dotnet ef database update

crear una carpeta Properties
y crear un archivo launchSettings.json
deveria de quedar asi:
Properties/launchSettings.json

copiar en el archivo este contenido reemplazando 
el valor de Super_Secret_Key 
```
{
  "$schema": "http://json.schemastore.org/launchsettings.json",
  "iisSettings": {
    "windowsAuthentication": false, 
    "anonymousAuthentication": true, 
    "iisExpress": {
      "applicationUrl": "http://localhost:27456",
      "sslPort": 44376
    }
  },
  "profiles": {
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "launchUrl": "api/values",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development",
        "Super_Secret_Key":"MY_SUPER_SECRET_KEY"
      }
    },
    "ApiRestNetCore2x": {
      "commandName": "Project",
      "launchBrowser": true,
      "launchUrl": "api/values",
      "applicationUrl": "https://localhost:5001;http://localhost:5000",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development",
        "Super_Secret_Key":"MY_SUPER_SECRET_KEY"
      }
    }
  }
} 
```