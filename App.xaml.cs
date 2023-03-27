namespace Maui_Issue14211;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
        // MainPage = new AppShell();
    }
}
