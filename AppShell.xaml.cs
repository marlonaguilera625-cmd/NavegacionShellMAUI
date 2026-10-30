using Microsoft.Extensions.DependencyInjection;
using NavegacionShellMAUI.Data;
using NavegacionShellMAUI.Views;
namespace NavegacionShellMAUI;
public partial class AppShell : Shell
{
 public AppShell(CursoRepository repository){InitializeComponent();var services=Application.Current!.Handler!.MauiContext!.Services;InicioContent.ContentTemplate=new DataTemplate(()=>services.GetRequiredService<InicioPage>());CursosContent.ContentTemplate=new DataTemplate(()=>services.GetRequiredService<CursosPage>());PerfilContent.ContentTemplate=new DataTemplate(()=>services.GetRequiredService<PerfilPage>());Routing.RegisterRoute("detallecurso",typeof(DetalleCursoPage));Routing.RegisterRoute("editarcurso",typeof(EditarCursoPage));}
 async void SalirClicked(object? sender,EventArgs e){if(await DisplayAlertAsync("Salir","¿Deseas cerrar la aplicación?","Salir","Cancelar"))Application.Current?.Quit();}
}
