
namespace Moana.View;

public partial class DetalleReceta : ContentPage
{
	public DetalleReceta()
	{
		InitializeComponent();
	}

    private async void TomarDosis_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Dosis Tomada", "La dosis ha sido tomada con �xito.", "OK");
    }

    private void Back_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PopAsync();
    }
}