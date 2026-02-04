📌 API de Gestión de Tareas – Actividad Entregable 1
📖 Descripción del Proyecto

Este proyecto consiste en una API RESTful desarrollada con ASP.NET Core (.NET 10) que permite gestionar tareas mediante operaciones CRUD.
La API permite crear, consultar, editar, eliminar y marcar tareas como completadas, simulando el almacenamiento de datos en memoria sin utilizar una base de datos.

El proyecto fue desarrollado en Visual Studio Community y probado utilizando Postman.

🛠️ Tecnologías Utilizadas

ASP.NET Core (.NET 10)

C#

Visual Studio Community

Postman

Almacenamiento en memoria (List<T>)

📂 Estructura del Proyecto
ActividadEntregable1
 ├── Controllers
 │   └── TaskController.cs
 ├── Models
 │   └── TaskModel.cs
 ├── Services
 │   └── TaskService.cs
 ├── Program.cs
 └── README.md

🧠 Implementación de la API RESTful

La API sigue los principios REST y está organizada en:

🔹 Controlador (TaskController)

Define los endpoints HTTP y gestiona las solicitudes del cliente.

🔹 Modelo (TaskModel)

Representa la estructura de una tarea con las siguientes propiedades:

Id: identificador único

Title: título de la tarea

Description: descripción

IsCompleted: estado de la tarea

🔹 Servicio (TaskService)

Simula el almacenamiento de datos utilizando una lista en memoria (List<TaskModel>), actuando como una base de datos temporal.

⚠️ Al reiniciar la aplicación, los datos se pierden.

🔁 Endpoints Disponibles
Método	Endpoint					Descripción
POST	/api/task					Crear una tarea
GET	/api/task						Obtener todas las tareas
PUT	/api/task/{id}					Editar una tarea
DELETE	/api/task/{id}				Eliminar una tarea
PATCH	/api/task/{id}/completar	Marcar tarea como completada

📡 Códigos de Estado HTTP

La API maneja correctamente los códigos de estado HTTP:

200 OK: Operación realizada con éxito

201 Created: Tarea creada correctamente

400 Bad Request: Datos inválidos o incompletos

404 Not Found: Recurso no encontrado

▶️ Cómo Ejecutar el Proyecto

Abrir el proyecto en Visual Studio Community

Ejecutar la aplicación (F5 o Ctrl + F5)

Confirmar que la API esté escuchando en:
http://localhost:5009

🧪 Pruebas con Postman
🔴 Crear una tarea (POST)

URL : http://localhost:5009/api/task		

Body (raw → JSON)

{
  "title": "Primera tarea",
  "description": "Prueba con Postman"
}

Respuesta esperada

201 Created

🔵 Obtener todas las tareas (GET)

URL

http://localhost:5009/api/task


Respuesta esperada

200 OK

Lista de tareas (puede estar vacía)

🟡 Editar tarea (PUT)

URL

http://localhost:5009/api/task/1


Body

{
  "title": "Tarea editada",
  "description": "Descripción actualizada"
}


Respuesta esperada

200 OK

🟣 Marcar tarea como completada (PATCH)

URL

http://localhost:5009/api/task/1/completar


🚫 No enviar body

Respuesta esperada

200 OK

🔴 Eliminar tarea (DELETE)

URL

http://localhost:5009/api/task/1


Respuesta esperada

200 OK

❌ Pruebas de Error

Ejemplos de pruebas para validar errores:

PATCH a una tarea inexistente:

PATCH /api/task/99/completar


➡ 404 Not Found

DELETE a una tarea inexistente:

DELETE /api/task/99


➡ 404 Not Found


🎓 Conclusión

Este proyecto demuestra la implementación de una API RESTful en ASP.NET Core utilizando almacenamiento en memoria, manejo adecuado de rutas, validaciones y códigos de estado HTTP, cumpliendo con las buenas prácticas de desarrollo de servicios web.