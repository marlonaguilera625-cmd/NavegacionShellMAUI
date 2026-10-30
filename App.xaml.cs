using NavegacionShellMAUI.Data;
namespace NavegacionShellMAUI;
public partial class App : Application
{
 readonly CursoRepository repository;
 public App(CursoRepository repository) { InitializeComponent(); this.repository=repository; }
 protected override Window CreateWindow(IActivationState? activationState)=>new(new AppShell(repository));
}
