﻿using Microsoft.Extensions.Configuration;

namespace OpenPOS_APP;

public partial class MainPage : ContentPage
{
	private int _count;
	private IConfiguration _configuration;
	public MainPage(IConfiguration config)
	{
		InitializeComponent();
		_configuration = config;
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		_count++;

		if (_count == 1)
			CounterBtn.Text = $"Clicked {_count} time";
		else
			CounterBtn.Text = $"Clicked {_count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

      var settings = _configuration.GetRequiredSection("TEST").Get<Settings>();
		await DisplayAlert("Config", $"{nameof(settings.testing_string)}: {settings.testing_string}" +
            $"{settings.testing_int} :  {settings.testing_int}", "OK");

   }

    
}

