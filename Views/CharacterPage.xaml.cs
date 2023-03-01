
using CommunityToolkit.Maui.Views;
using GearInsight.Models;
using Microsoft.Maui.Controls;
using System.Reflection;

namespace GearInsight.Views;


public partial class CharacterPage : ContentPage
{
	public CharacterPage()
	{
		InitializeComponent();

	}
    
    private void HeadButton_Clicked(object sender, EventArgs e)
    {
        int headId = int.Parse(HeadButton.Text);
        this.ShowPopup(new PopupPage(headId));
    }

    private void NeckButton_Clicked(object sender, EventArgs e)
    {

    }

    private void ShoulderButton_Clicked(object sender, EventArgs e)
    {

    }
    

    private void ChestButton_Clicked(object sender, EventArgs e)
    {

    }

    private void ShirtButton_Clicked(object sender, EventArgs e)
    {

    }

    private void TabardButton_Clicked(object sender, EventArgs e)
    {

    }

    private void WristButton_Clicked(object sender, EventArgs e)
    {

    }

    private void MainhandButton_Clicked(object sender, EventArgs e)
    {

    }

    private void ÓffhandButton_Clicked(object sender, EventArgs e)
    {

    }

    private void OffhandButton_Clicked(object sender, EventArgs e)
    {

    }

    private void HandButton_Clicked(object sender, EventArgs e)
    {

    }

    private void WaistButton_Clicked(object sender, EventArgs e)
    {

    }

    private void LegsButton_Clicked(object sender, EventArgs e)
    {

    }

    private void FeetButton_Clicked(object sender, EventArgs e)
    {

    }

    private void Ring1Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Ring2Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Trinket1Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Trinket2Button_Clicked(object sender, EventArgs e)
    {

    }

    private void BackButton_Clicked(object sender, EventArgs e)
    {

    }

    private async void GoBackToMainPage_Clicked(object sender, EventArgs e)
    {
        
        await Navigation.PopAsync();
        
    }
}