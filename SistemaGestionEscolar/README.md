# Sistema de Gestión Escolar

Proyecto web desarrollado con ASP.NET Core MVC (.NET 10), Entity Framework Core y SQL Server, aplicando el patrón de arquitectura Modelo-Vista-Controlador.

## Equipo de Desarrollo y Entidades

| Integrante | Entidad a cargo |
| :--- | :--- |
| **1. ALEXANDER SEBASTIAN JACOME SAN LUCAS** | Estudiante |
| **2. VANESSA FERNANDA CHIRIGUAYA RUALES** | Maestro |
| **3. LUIS ALEJANDRO SANCHEZ DURAN** | Aula |
| **4. JHOAN DAVID PUCO ALCIVAR** | Libro |
| **5. ISRAEL FERNANDO PORTILLA SANTAMARIA** | Materia |

## Instrucciones para ejecutar el proyecto

Para correr el proyecto en un entorno local y configurar la base de datos con todos los CRUDs, sigue estos pasos:

1. **Clonar el repositorio:**
   Abre Visual Studio y selecciona *Clonar un repositorio* usando la URL del proyecto en GitHub.
   
2. **Configurar la cadena de conexión:**
   Abre el archivo `appsettings.json` y verifica que el servidor de SQL Server coincida con tu instancia local. Si tu servidor se llama diferente, ajusta la propiedad `Server`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=SistemaEscolarDB;Trusted_Connection=True;TrustServerCertificate=True;"
   }