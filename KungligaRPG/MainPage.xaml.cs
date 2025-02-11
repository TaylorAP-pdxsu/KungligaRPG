namespace KungligaRPG
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            bindTest();
        }

        private void bindTest()
        {
            KungligaRPG.Models.Character testC = new Models.Character();

            Binding characterBind = new Binding();
            characterBind.Source = testC;
            characterBind.Path = "name";
            characterName.SetBinding(Label.TextProperty, characterBind);

            Binding phyBind = new Binding();
            phyBind.Source = testC.physique;
            phyBind.Path = "attrName";
            characterPhy.SetBinding(Label.TextProperty, phyBind);

            Binding dexBind = new Binding();
            dexBind.Source = testC.dexterity;
            dexBind.Path = "attrName";
            characterDex.SetBinding(Label.TextProperty, dexBind);

            Binding menBind = new Binding();
            menBind.Source = testC.mentality;
            menBind.Path = "attrName";
            characterMen.SetBinding(Label.TextProperty, menBind);

            Binding chaBind = new Binding();
            chaBind.Source = testC.charisma;
            chaBind.Path = "attrName";
            characterCha.SetBinding(Label.TextProperty, chaBind);
        }
    }

}
