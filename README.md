# Proyecto Electiva II – API REST de Gestión de Tareas (.NET 10)

Este proyecto corresponde a una **API RESTful** desarrollada en **ASP.NET Core (.NET 10)** que permite gestionar tareas mediante operaciones CRUD, utilizando una **lista en memoria** (sin base de datos).

La API fue desarrollada como parte de la asignatura **Electiva II** y se prueba utilizando **Postman**.

---

## 🛠️ Tecnologías utilizadas

- .NET 10
- ASP.NET Core Web API
- Visual Studio Community
- Postman
- GitHub

---

## 📂 Estructura del proyecto

- Controllers: Controladores de la API
- Models: Modelos de datos
- Interface: Interfaces de servicios
- Services: Lógica de negocio
- Program.cs: Configuración de la aplicación

---

## ▶️ Ejecución del proyecto

1. Abrir el proyecto en **Visual Studio Community**.
2. Verificar que no existan errores de compilación.
3. Ejecutar el proyecto con **F5** o **Ctrl + F5**.
4. En la consola se mostrará una URL similar a:

http://localhost:5009


Esta será la URL base de la API.

---

## 🧪 Pruebas de la API con Postman

### ➕ Crear una tarea (POST)

Método: POST  
URL: http://localhost:5009/api/tasks

Body (JSON):

{
  "title": "Mi primera tarea",
  "description": "Probando la API"
}

Método: GET

URL: http://localhost:5009/api/tasks

Método: PUT

URL:http://localhost:5009/api/tasks/1

Body (JSON):

{
  "title": "Tarea editada",
  "description": "Descripción actualizada"
}

Método: PATCH

URL: http://localhost:5009/api/tasks/1/completar

Método: DELETE

URL: http://localhost:5009/api/tasks/1

