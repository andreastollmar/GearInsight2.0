using GearInsight.Models;
using GearInsight.Database;
using GearInsight.Views;
using GearInsight.ViewModels;

namespace GearInsight;

public partial class MainPage : ContentPage
{	

	public MainPage()
	{
		InitializeComponent();
	}

	private async void FindCharacter_Clicked(object sender, EventArgs e)
	{
		var name = Charactername.Text;
		var realm = Realm.Text;
		Character character = await Mongo.CreateCharacter(name, realm);
		if (character != null)
		{
			var page = new CharacterPage();
			page.BindingContext = character;
			await Navigation.PushAsync(page);
		}
	}
}

