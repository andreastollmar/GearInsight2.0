using CommunityToolkit.Maui.Views;

namespace GearInsight.Views;

public partial class PopupPage : Popup
{
	public PopupPage(int nr)
	{
		InitializeComponent();
		showInfo.Text = "www.wowhead.com/item=" + nr;


		// skapa en webview eller javascrips sak för att visa bättre med hjälp av texten ovanför
		// döpa alla knappar och skapa parse för att få inten
	}
}