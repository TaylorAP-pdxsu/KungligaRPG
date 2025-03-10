using KungligaRPG.UI;
using KungligaRPG.Pages;

namespace KungligaRPG
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            KungligaRPG.Models.Character testC = new Models.Character();

            UICharacter uICharacter = new UICharacter();
            uICharacter.CopyCharacterToStrings(testC);
            uICharacter.BindToModel(this);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreatorPage());
        }
    }

}
