using GearInsight.Models;
using GearInsight.Database;
using GearInsight.Views;
using GearInsight.ViewModels;
using CommunityToolkit.Maui.Views;

namespace GearInsight;

public partial class MainPage : ContentPage
{
	int count = 0;
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

    private void CounterClicked_Clicked(object sender, EventArgs e)
    {
		count++;

		if (count == 1)
		{
			CounterClicked.Text = $"Clicked {count} time";
		}
		else
		{
			CounterClicked.Text = $"Clicked {count} times";
		}
		this.ShowPopup(new PopupPage(32));

    }
}

