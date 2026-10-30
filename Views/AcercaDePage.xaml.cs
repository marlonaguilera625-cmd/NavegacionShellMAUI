namespace NavegacionShellMAUI.Views;
public partial class AcercaDePage : ContentPage { public AcercaDePage(){InitializeComponent();} async void RegresarClicked(object? sender,EventArgs e)=>await Shell.Current.GoToAsync(".."); }
