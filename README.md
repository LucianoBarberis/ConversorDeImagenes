# Conversor de Imágenes

Una aplicación de escritorio simple y eficiente para Windows construida con .NET 10 y Windows Forms. Esta herramienta permite convertir imágenes entre diferentes formatos populares utilizando la potente librería [Magick.NET](https://github.com/dlemstra/Magick.NET).

## 🛠️ Tecnologías Utilizadas

- **C# / .NET 10**: Framework principal.
- **Windows Forms**: Interfaz de usuario.
- **Magick.NET-Q8-AnyCPU**: Librería para el procesamiento y conversión de imágenes.

## 📋 Requisitos Previos

Para ejecutar o compilar este proyecto, necesitas:

- Sistema Operativo Windows (requerido para Windows Forms).
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) instalado.
- Visual Studio 2022 (opcional, pero recomendado) o VS Code.

## 🔧 Instalación y Ejecución

1. **Clonar el repositorio**:
   ```bash
   git clone <URL-del-repositorio>
   cd Conversor
   ```

2. **Restaurar dependencias**:
   El proyecto utiliza NuGet para gestionar paquetes. Ejecuta el siguiente comando para descargar Magick.NET y otras dependencias:
   ```bash
   dotnet restore
   ```

3. **Ejecutar la aplicación**:
   Puedes correr la aplicación directamente desde la terminal:
   ```bash
   dotnet run
   ```
   O abrir el archivo `Conversor.slnx` o `Conversor.csproj` en Visual Studio y presionar `F5`.

## 📖 Cómo Usar

1. Abre la aplicación.
2. Haz clic en el botón para **Cargar Imagen** y selecciona el archivo que deseas convertir.
   - *Formatos soportados de entrada: PNG, JPG, JPEG, GIF, ICO.*
3. La aplicación detectará automáticamente el formato de origen.
4. Selecciona el formato de destino deseado en el menú desplegable.
5. Haz clic en **Convertir**.
6. Aparecerá un mensaje confirmando la ruta donde se guardó la nueva imagen (usualmente en `C:\Users\TuUsuario\Pictures\ImagenesConvertidas`).

## 📄 Estructura del Proyecto

- `Form1.cs`: Contiene la lógica principal de la interfaz y la conversión.
- `Conversor.csproj`: Archivo de configuración del proyecto y dependencias (incluye referencia a Magick.NET).

## 🤝 Contribución

¡Las contribuciones son bienvenidas! Si encontras un error o queres mejorar la herramienta:

1. Hace un Fork del proyecto.
2. Crea una rama para tu funcionalidad (`git checkout -b feature/nueva-feature`).
3. Haz Commit de tus cambios (`git commit -m 'Agrega nueva feature'`).
4. Haz Push a la rama (`git push origin feature/nueva-feature`).
5. Abre un Pull Request.
