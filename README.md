# Navegación Académica

Aplicación académica de demostración de Shell Navigation desarrollada con C#, .NET 10 MAUI y XAML. Presentación 4: Navegación con Shell.

## Objetivo

Demostrar una navegación principal con tres pestañas, un menú Flyout y el paso de parámetros entre páginas para consultar y editar cursos mantenidos en memoria.

## Tecnologías y requisitos

- C# y .NET 10 SDK con workload .NET MAUI instalado.
- Visual Studio con desarrollo de aplicaciones .NET MAUI o CLI `dotnet`.
- Destinos configurados: Android, iOS, Mac Catalyst y Windows.
- No utiliza base de datos ni paquetes externos adicionales.

## Estructura

- `Models/Curso.cs`: entidad observable Curso.
- `Data/CursoRepository.cs`: fuente singleton en memoria con cinco cursos.
- `Views/`: páginas Inicio, Cursos, Perfil, Detalle, Edición y Acerca de.
- `AppShell.xaml`: TabBar/Flyout y destinos principales.
- `Resources/Styles/`: colores y estilos claros/oscuros.
- `docs/capturas/`: ubicación para evidencias tomadas por el estudiante.

## Navegación Shell

La TabBar contiene Inicio, Cursos y Perfil. El Flyout permite acceder a esas secciones y a Acerca de. Salir solicita confirmación y usa `Application.Current.Quit()`; el cierre efectivo depende de las reglas del sistema operativo.

### Mapa de rutas

| Destino | Acceso |
|---|---|
| Inicio | Pestaña principal `//inicio` |
| Cursos | Pestaña principal `//cursos` |
| Perfil | Pestaña principal `//perfil` |
| Acerca de | Flyout / `acercade` |
| Detalle | Ruta registrada `detallecurso?id=1` |
| Edición | Ruta registrada `editarcurso` |

Desde Cursos se envía solamente el Id en query string. Detalle implementa `IQueryAttributable` y busca el Id en el repositorio. De Detalle a Edición se envía el objeto `Curso` mediante `ShellNavigationQueryParameters`; Edición valida y actualiza el objeto existente, sin insertar otro elemento.

Los botones Regresar y Cancelar navegan con `..`. Cancelar descarta la edición porque los campos se aplican al objeto únicamente al guardar. `CursosPage.OnAppearing()` vuelve a consultar el repositorio al regresar y enlaza de nuevo la lista.

## Repositorio

`CursoRepository` se registra como Singleton en MAUI. Mantiene cinco cursos en una lista durante la ejecución y ofrece `ObtenerTodos`, `ObtenerPorId` y `Actualizar`. Los cambios no persisten al cerrar la aplicación.

## Diseño

Paleta: Primary `#176B87`, Secondary `#12304A`, Accent `#28A8C7`, Background `#F3F6FA`, Surface `#FFFFFF`, TextPrimary `#183247`, TextSecondary `#64748B`, Success `#16845B`, Danger `#DC4545`. Los estilos incluyen variantes de tema oscuro.

## Ejecución

Desde la carpeta del proyecto:

```powershell
dotnet build NavegacionShellMAUI.csproj
dotnet build NavegacionShellMAUI.csproj -f net10.0-windows10.0.19041.0
```

Abre `NavegacionShellMAUI.slnx` en Visual Studio y selecciona un destino disponible para ejecutar la aplicación.

## Capturas

No se incluyen capturas inventadas. Guarda las evidencias reales en `docs/capturas/`. Nombres recomendados: `01-inicio.png`, `02-cursos.png`, `03-detalle.png`, `04-edicion.png`, `05-perfil.png`, `06-flyout-acerca.png` y `07-tema-oscuro.png`. Estas capturas están pendientes de realizar en un dispositivo/emulador.
