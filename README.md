# TrueHome.CRUD
CRUD de prueba tecnica

### Reference Documentation
For further reference, please consider the following sections:

* [ASP Net Core 5](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/target-aspnetcore?view=aspnetcore-6.0&tabs=visual-studio)

## Introduction

Esta API contiene un CRUD para la administración del catálogo de actividades, el body request para la mayoria de los catálogos es en formato JSON y los servicios REST que estan contenidos dentro de la API son los siguiente:

```Obtener todas las actividades
https://localhost:44348/ActividadAPI/obtenerActividades
```

```Obtener actividades por filtro
https://localhost:44348/ActividadAPI//ActividadAPI/obtenerFiltroActividades
```

```Agregar actividad
https://localhost:44348/ActividadAPI/agregarActividad
```

```Actualizar actividad
https://localhost:44348/ActividadAPI/actualizarActividad
```

```Cancelar actividad (Este servicio necesita un parametro id para poder cancelar la actividad)
https://localhost:44348/ActividadAPI/cancelarActividad?id=
```

## How to Run it

### Local run using the terminal

```URL Local Host
http://localhost:44348
```

