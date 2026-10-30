using NavegacionShellMAUI.Data;
using NavegacionShellMAUI.Models;
namespace NavegacionShellMAUI.Views;
public partial class CursosPage : ContentPage { readonly CursoRepository repo; public CursosPage(CursoRepository repo){InitializeComponent();this.repo=repo;} protected override void OnAppearing(){base.OnAppearing();CoursesList.ItemsSource=repo.ObtenerTodos().ToList();CountLabel.Text=$"Cursos disponibles · {repo.ObtenerTodos().Count}";} async void DetalleClicked(object? s,EventArgs e){if((s as BindableObject)?.BindingContext is Curso c)await Shell.Current.GoToAsync($"detallecurso?id={Uri.EscapeDataString(c.Id.ToString())}");} async void EditarClicked(object? s,EventArgs e){if((s as BindableObject)?.BindingContext is Curso c)await Shell.Current.GoToAsync("editarcurso",new ShellNavigationQueryParameters{{"curso",c}});} }

