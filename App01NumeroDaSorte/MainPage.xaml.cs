namespace App01NumeroDaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnGenerateLuckNumbers(object sender, EventArgs e)
	{
		NameApp.IsVisible = !NameApp.IsVisible;
		ContainerLuckNumber.IsVisible = !ContainerLuckNumber.IsVisible;

    }
}