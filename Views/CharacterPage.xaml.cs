namespace GearInsight.Views;

public partial class CharacterPage : ContentPage
{
	public CharacterPage()
	{
		InitializeComponent();
	}
    protected override void OnSizeAllocated(double pageWidth, double pageHeight)
    {
        base.OnSizeAllocated(pageWidth, pageHeight);
        const double aspectRatio = 1600 / 1200;        
        HeadImage.WidthRequest = Math.Max(pageHeight * aspectRatio, pageWidth);
        // HeadImage.HeightRequest = Math.Max(pageWidth * aspectRatio, pageHeight);
    }
}