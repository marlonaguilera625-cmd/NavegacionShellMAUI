using NavegacionShellMAUI.Models;
namespace NavegacionShellMAUI.Data;
public sealed class CursoRepository
{
    private readonly List<Curso> cursos =
    [
        Crear(1,"Programación en C#","Fundamentos del lenguaje, tipos, colecciones y programación orientada a objetos.","María López","12 semanas","Programación","Básico",4),
        Crear(2,"Redes de computadoras","Modelos de red, direccionamiento IP, conmutación y servicios.","Carlos Rivera","10 semanas","Redes","Intermedio",3),
        Crear(3,"Bases de datos","Diseño relacional, SQL, consultas, transacciones y normalización.","Ana Martínez","12 semanas","Datos","Intermedio",4),
        Crear(4,"Ingeniería de software","Requisitos, diseño, pruebas y ciclo de vida de productos de software.","Jorge Pérez","14 semanas","Ingeniería","Intermedio",4),
        Crear(5,"Desarrollo de aplicaciones móviles","Diseño de interfaces y desarrollo multiplataforma con .NET MAUI.","Lucía Gómez","12 semanas","Desarrollo móvil","Intermedio",4)
    ];
    static Curso Crear(int id,string nombre,string descripcion,string instructor,string duracion,string categoria,string nivel,int creditos) => new(){Id=id,Nombre=nombre,Descripcion=descripcion,Instructor=instructor,Duracion=duracion,Categoria=categoria,Nivel=nivel,Creditos=creditos};
    public IReadOnlyList<Curso> ObtenerTodos() => cursos;
    public Curso? ObtenerPorId(int id) => cursos.FirstOrDefault(c=>c.Id==id);
    public bool Actualizar(Curso curso) => cursos.Any(c=>c.Id==curso.Id);
}
