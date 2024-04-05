using MauiNavigateShell.View;
using MauiNavigateShell.ViewModel;


namespace MauiNavigateShell;

public partial class App : Application
{
    
	public App()
	{
              
        InitializeComponent();

        MainPage = new AppShell();
    }

    
}
