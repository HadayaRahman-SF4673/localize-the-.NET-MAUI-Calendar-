using System.Globalization;
namespace Localization;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("ja-JP");

        MainPage = new AppShell();
	}
}
