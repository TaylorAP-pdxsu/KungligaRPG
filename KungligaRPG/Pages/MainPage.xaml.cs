using KungligaRPG.UI;
using KungligaRPG.Pages;
using static System.Net.Mime.MediaTypeNames;

namespace KungligaRPG
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(Models.Character createdCharacter)
        {
            InitializeComponent();

            Models.Character character = new Models.Character(createdCharacter);
            UICharacter uICharacter = new UICharacter();
            uICharacter.CopyCharacterToStrings(character);
            uICharacter.BindToModel(this);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreatorPage());
        }
    }

}
