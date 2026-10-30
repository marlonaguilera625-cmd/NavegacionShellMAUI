using Microsoft.Extensions.Logging;
using NavegacionShellMAUI.Data;
using NavegacionShellMAUI.Views;
namespace NavegacionShellMAUI;
public static class MauiProgram
{
 public static MauiApp CreateMauiApp() { var b= MauiApp.CreateBuilder().UseMauiApp<App>(); b.Services.AddSingleton<CursoRepository>(); b.Services.AddTransient<InicioPage>(); b.Services.AddTransient<CursosPage>(); b.Services.AddTransient<PerfilPage>(); b.Services.AddTransient<DetalleCursoPage>(); b.Services.AddTransient<EditarCursoPage>(); b.Services.AddTransient<AcercaDePage>();
 b.ConfigureFonts(f=>{f.AddFont("OpenSans-Regular.ttf","OpenSansRegular");f.AddFont("OpenSans-Semibold.ttf","OpenSansSemibold");});
 #if DEBUG
 b.Logging.AddDebug();
 #endif
 return b.Build(); }
}
