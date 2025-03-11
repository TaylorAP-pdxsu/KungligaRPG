using KungligaRPG.Models;
using KungligaRPG.UI;
using System.Collections.ObjectModel;

namespace KungligaRPG.Pages
{

	public partial class CreatorPage : ContentPage
	{
		UICreator Creator;

		public CreatorPage()
		{

            InitializeComponent();
			Creator = new UICreator(this);
			this.BindingContext = Creator;
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			Character character = new Character();

			Creator.RetrieveDataList(character);

			Navigation.PushAsync(new MainPage(character));
		}

        private void AddArmor(object sender, EventArgs e)
        {
			Creator.addArmorToList();
        }

		private void AddWeapon(object sender, EventArgs e)
		{
			Creator.addWeaponToList();
		}
    }
}