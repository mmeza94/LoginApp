# Alcance de proyecto
## Tabla de objetivos

* [Manejo del archivo SQL](#manejo-del-archivo-sql)
  * [Retos](#retos)
* [Alcance de base de datos](#alcance-de-base-de-datos)


## Manejo del archivo SQL

El archivo data.sql es el que prepare es referente a un sistema de escuela, la estructura viene de MySQL así que si lo quieres ocupar para alguna otra base de datos tendrás que pasarlo al formato de la base de datos que vayas a ocupar.

### Retos:

- Identificar porque no es compatible con otras bases de datos.
- Solucionar problemas de incompatibilidad que puedan llegar a surgir.


## Alcance de base de datos

El proyecto lo pensé con los siguientes retos que podrían llegar a ser interesantes y buenos para aprender un poco más.

### Ideas para el desarrollo del proyecto.
- Validar el login con los datos del archivo data.sql
- El evitar que existan registros duplicados de personas.
- El user deberá de ser único.
- Aplicar el principio de POO en tablas que repitan datos.
- Ver el tema de integridad referencial al momento de querer eliminar un dato o actualizarlo [ON UPDATE / ON DELETE].
- Creación de índices para el tema de rendimiento.
- Recuperación de contraseña para los usuarios.
- Actualizar datos de los registros existentes.
- Mostrar

### Modulos extras
- Creación del módulo de grupos
  - Que los alumnos puedan ser parte de un grupo, sin que estén duplicados.
  - Los grupos deberán de pertenecer a maestro
- Creación del módulo de calificaciones
  - Las materias podrán tener maestro o será el mismo maestro del grupo

### Avanzado [pendiente]
- [ Temas de replicación] Principio de maestro - esclavo / maestro - maestro
