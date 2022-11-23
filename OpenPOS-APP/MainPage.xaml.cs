using Microsoft.Extensions.Configuration;

namespace OpenPOS_APP;

public partial class MainPage : ContentPage
{
	private int _count;
	private IConfiguration _configuration;
	public MainPage()
    {
        InitializeComponent();
    }

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		_count++;

		if (_count == 1)
			CounterBtn.Text = $"Clicked {_count} time";
		else
			CounterBtn.Text = $"Clicked {_count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

    }

    
}

