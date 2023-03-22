# TalentoDigital api.NETCore6
> https://tecnochile.netlify.app/

Este proyecto esta relacionado con los siguentes proyectos de GitHub

* Cargar tus datos a la API
    https://github.com/TheNefelin/td_CargarBD_en_Api.git
* Sitio Web: (Html5, CSS3, JS)
	https://github.com/TheNefelin/td_trabajo_grupal_03.git
* WebApi: (.NET Core 6 C#)
    https://github.com/TheNefelin/td_api.NetCore6.git
* Base de Datos: (SQL Server)
	https://github.com/TheNefelin/td_SQL-Server.git

# WebAPI
para que corra correctamente se debe agregar en el proyecto de WebApi el archivo "appsettings.json" con la configuracion del origen de datos
1. Data Source={nombre de tu servidor SQL}
2. Initial Catalog=DataBase{Nombre de la Base de Datos}
3. User ID={Tu Usuario SQL (sa u otro)}
4. Password={Tu Contraseña de tu usuario SQL}

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "RutaSQL": "Data Source=Server; Initial Catalog=DataBase; User ID=User; Password=PassWord"
  }
}
```
