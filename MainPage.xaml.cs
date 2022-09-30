namespace OP;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnSettingsMoveAsync(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//Settings");
    }

	private async void btn_dialer_Clicked(object sender, EventArgs e)
	{
		Button btn = (Button)sender;
		string num = "";
		if(btn.Text == "Gurskogo")
		{
			if (Data.gurskogo == "")
			{
				num = await SecureStorage.Default.GetAsync("gur");
			}
			else
			{
				num = Data.gurskogo;
			}            
		}
		else
		{
			if (Data.chapaeva == "")
			{
				num = await SecureStorage.Default.GetAsync("chap");
			}
			else
			{
				num = Data.chapaeva;
			}            
        }
		if(num == "")
		{
			num = "000000";
			Data.InvokeDialer(num);
		}
		else
		{
			num = "000000";
            await DisplayAlert("Alert", "No enter phone number", "OK");
        }
	}

	private async void btn_about_Clicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//About");
    }
}

