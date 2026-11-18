# Control de inventario de TecnoPunto

## Datos del autor
- **Nombre:** [TU NOMBRE COMPLETO]
- **Matrícula:** [TU MATRÍCULA]
- **Asignatura:** Programación Básica
- **Profesor:** Gamalier Reyes del Carmen

## Descripción del programa
Aplicación de consola en C# que registra productos de la tienda TecnoPunto y muestra su información de forma confiable. La clase `Producto` encapsula sus datos con propiedades que validan la información (nombre no vacío, precio mayor que 0 y cantidad no negativa) y calcula por sí misma el valor total en existencia.

## Datos de entrada
Para cada uno de los 3 productos, el usuario ingresa por teclado:
- Código
- Nombre
- Precio
- Cantidad

## Datos que procesa
- Valida que el nombre no esté vacío, que el precio sea mayor que 0 y que la cantidad no sea negativa.
- Verifica que precio y cantidad sean números.
- Calcula el valor total de cada producto: `ValorTotal = Precio × Cantidad`.
- Si un dato es inválido, muestra un mensaje de error y vuelve a pedir los datos del producto (el programa no se cierra).

## Datos de salida
Para cada producto: código, nombre, precio, cantidad y valor total.

## Estructura del proyecto
- `Producto.cs`: clase `Producto` (propiedades, constructor y `MostrarInfo()`).
- `Program.cs`: método `Main` y lectura de datos por teclado.

## Capturas de ejecución

### 1. Datos válidos
![Datos válidos](capturas/datos-validos.png)

### 2. Precio negativo
![Precio negativo](capturas/precio-negativo.png)

### 3. Nombre vacío
![Nombre vacío](capturas/nombre-vacio.png)

### 4. Cantidad cero
![Cantidad cero](capturas/cantidad-cero.png)
