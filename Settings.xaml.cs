namespace OP;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
	}

	private async void btn_back_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//MainPage");
    }

	private async void gursk_Completed(object sender, EventArgs e)
	{
		Entry entry = (Entry)sender;
		Data.gurskogo = entry.Text;
        await SecureStorage.Default.SetAsync("gur", entry.Text);
    }

	private async void chap_Completed(object sender, EventArgs e)
	{
        Entry entry = (Entry)sender;
        Data.chapaeva = entry.Text;
        await SecureStorage.Default.SetAsync("chap", entry.Text);
    }
}