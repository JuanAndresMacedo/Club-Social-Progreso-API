# Descripción general

La solución titulada **"CSP-API"** es una API REST realizada con .NET Core 8.0 que permite administrar las noticias relacionadas con el **Club Social Progreso**.

Esta API facilita la comunicación entre el front end, desarrollado en **Angular**, y la base de datos (**SQL Server**). Proporciona endpoints para obtener las noticias de diversas maneras, permitiendo una gestión eficiente del contenido del club.

En el futuro, se planea incorporar la gestión de usuarios y permisos, así como ampliar las funcionalidades relacionadas con las noticias, permitiendo crear, actualizar y eliminar contenido.

# Tecnologías Utilizadas

**Frameworks y Librerías**

- ASP.NET Core: Framework utilizado para desarrollar la API REST, ofreciendo un entorno robusto, seguro y de alto rendimiento.

- Entity Framework Core: ORM que facilita la interacción con la base de datos. Se utilizó el enfoque **"Code First"**, en el que se definen los modelos y estructuras de datos en el código, y mediante migraciones, EF Core crea y actualiza la base de datos en base a dichos modelos.

**Base de Datos**

- SQL Server: Sistema de gestión de bases de datos **relacional** que almacena y gestiona la información de las noticias del club, garantizando integridad y rendimiento.

**Hosting**

- AWS: Plataforma utilizada para el hosting y despliegue de la aplicación, proporcionando escalabilidad y alta disponibilidad en la nube. Una descripción más detallada de la **infraestructura** se encuentra en el [README del proyecto Angular](https://github.com/JuanAndresMacedo/Club-Social-Progreso-WebApp).

# Estructura del Proyecto

**Diagrama de paquetes**

![Diagrama de paquetes](imagenesREADME/diagrama%20de%20paquetes.png)

**Business Logic**   
Este paquete contiene las clases de los diferentes servicios de la aplicación. A su vez cuenta con las interfaces de estos servicios, la interfaz del repositorio relacionado al acceso a datos y los elementos del dominio del problema. En definitiva, este paquete agrupa la lógica y todo lo relacionado a los requerimientos del proyecto.

**CSP-API**   
La finalidad de este paquete es atender las solicitudes HTTP. El mismo está conformado por los controladores para acceder a cada recurso.

**DataBase**   
En este paquete se encuentra el contexto de la base de datos, la implementación del repositorio genérico para el acceso a los mismos y las migraciones realizadas. A su vez, se encuentran repositorios de cada entidad que heredan del repositorio genérico. Estos repositorios sirven para incluir los objetos dentro de la entidad a la hora de traerlos de la base de datos.

# Recursos y Endpoints

**URL base:** `/news`  
**Recurso:** News  
**Descripción:** Este recurso maneja operaciones relacionadas a la visualización de todas las peticiones, las seis peticiones más recientes y una petición específica según su id.  

| Verbo | URI                   | Parámetros | Responses     | Headers |
|-------|------------------------|------------|--------------|---------|
| GET   | `/getAll`              | -          | 200, 403, 500 | -       |
| GET   | `/getLatestNews`       | -          | 200, 403, 500 | -       |
| GET   | `/getById/{newsId}`    | -          | 200, 403, 500 | -       |
