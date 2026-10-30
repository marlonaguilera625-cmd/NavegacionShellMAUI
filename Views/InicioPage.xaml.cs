using NavegacionShellMAUI.Data;
namespace NavegacionShellMAUI.Views;
public partial class InicioPage : ContentPage { readonly CursoRepository repo; public InicioPage(CursoRepository repo){InitializeComponent();this.repo=repo;} protected override void OnAppearing(){base.OnAppearing();CountLabel.Text=$"{repo.ObtenerTodos().Count} cursos disponibles";} async void CursosClicked(object? s,EventArgs e)=>await Shell.Current.GoToAsync("//cursos"); async void PerfilClicked(object? s,EventArgs e)=>await Shell.Current.GoToAsync("//perfil"); }

