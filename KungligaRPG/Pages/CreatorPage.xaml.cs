using KungligaRPG.Models;
using KungligaRPG.UI;

namespace KungligaRPG.Pages;

public partial class CreatorPage : ContentPage
{
	public CreatorPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Character character = new Character();
		UICreator creator = new UICreator(this);

		creator.RetrieveDataList(character.attributes);

		Navigation.PushAsync(new MainPage());
    }
}