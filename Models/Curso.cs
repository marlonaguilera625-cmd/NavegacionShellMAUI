using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace NavegacionShellMAUI.Models;
public sealed class Curso : INotifyPropertyChanged
{
    string nombre = string.Empty, descripcion = string.Empty, instructor = string.Empty, duracion = string.Empty, categoria = string.Empty, nivel = string.Empty;
    public int Id { get; init; }
    public string Nombre { get => nombre; set => Set(ref nombre, value); }
    public string Descripcion { get => descripcion; set => Set(ref descripcion, value); }
    public string Instructor { get => instructor; set => Set(ref instructor, value); }
    public string Duracion { get => duracion; set => Set(ref duracion, value); }
    public string Categoria { get => categoria; set => Set(ref categoria, value); }
    public string Nivel { get => nivel; set => Set(ref nivel, value); }
    public int Creditos { get; set; }
    public string Color { get; init; } = "#176B87";
    public event PropertyChangedEventHandler? PropertyChanged;
    void Set(ref string field, string value, [CallerMemberName] string? propertyName = null) { if(field == value) return; field=value; PropertyChanged?.Invoke(this,new(propertyName)); }
}
