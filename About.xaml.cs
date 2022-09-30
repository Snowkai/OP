namespace OP;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();
	}

	private async void btn_about_back_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//MainPage");
    }
}