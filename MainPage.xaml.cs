using CommunityToolkit.Maui.Core;

namespace MauiStatusBarBehaviour;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnBlueClicked(object sender, EventArgs e)
    {
        CommunityToolkit.Maui.Core.Platform.StatusBar.SetColor(Colors.Blue);
        CommunityToolkit.Maui.Core.Platform.StatusBar.SetStyle(StatusBarStyle.LightContent);
    }

    private void OnGreenClicked(object sender, EventArgs e)
    {
        CommunityToolkit.Maui.Core.Platform.StatusBar.SetColor(Colors.Green);
        CommunityToolkit.Maui.Core.Platform.StatusBar.SetStyle(StatusBarStyle.LightContent);
    }

    private void OnDefaultClicked(object sender, EventArgs e)
    {
        CommunityToolkit.Maui.Core.Platform.StatusBar.SetColor(Color.FromHex("#2B0B98"));
        CommunityToolkit.Maui.Core.Platform.StatusBar.SetStyle(StatusBarStyle.LightContent);
    }
}

