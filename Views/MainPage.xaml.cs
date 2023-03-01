using GearInsight.Models;
using GearInsight.Database;
using GearInsight.Views;
using GearInsight.ViewModels;
using CommunityToolkit.Maui.Views;

namespace GearInsight;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}


	



	private async void FindCharacter_Clicked(object sender, EventArgs e)
	{
		var name = Charactername.Text.ToLower();
		var realm = Realm.Text.ToLower();
		Character character = await Mongo.CreateCharacter(name, realm);
		if (character != null)
		{
			var page = new CharacterPage();
			page.BindingContext = character;
			await Navigation.PushAsync(page);
		}
	}

    
}

