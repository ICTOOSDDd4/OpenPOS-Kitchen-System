

namespace OpenPOS_APP;

public partial class LogOutPage : ContentPage
{
	public LogOutPage()
	{
		InitializeComponent();

        Button logoutButton = new Button
        {
            Text = "Logout",
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        logoutButton.Clicked += OnLogoutButtonClicked;
    } 
    async void OnLogoutButtonClicked(object sender, EventArgs e)
    {
        //TODO: Logout
    }

    

}