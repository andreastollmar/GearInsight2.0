using CommunityToolkit.Maui.Views;

namespace GearInsight.Views;

public partial class PopupPage : Popup
{
	public PopupPage(int nr)
	{
		InitializeComponent();
		showInfo.Text = "www.wowhead.com/item=" + nr;


		// skapa en webview eller javascrips sak f�r att visa b�ttre med hj�lp av texten ovanf�r
		// d�pa alla knappar och skapa parse f�r att f� inten
	}
}