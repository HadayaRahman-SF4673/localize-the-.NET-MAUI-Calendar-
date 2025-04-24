using System.Globalization;
namespace Localization;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("ja-JP");
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        return new Window(new AppShell());
    }
}
