using KungligaRPG.Interfaces;
using KungligaRPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace KungligaRPG.UI
{
    class UICharacter : IUIModelUseCase
    {
        public SortedList<string, Models.Attribute> attributes { get; set;}
        public Weapon weapon { get; set;}
        public Armor armor { get; set;}

        public UICharacter() {
            attributes = new SortedList<string, Models.Attribute>();
            weapon = new Weapon();
        }

        //Convert all attributes to strings
        public void CopyCharacterToStrings(Character inputModel)
        {
            attributes = new SortedList<string, Models.Attribute>(inputModel.attributes);
            weapon = new Weapon(inputModel.weapon, this.attributes);
            armor = new Armor(inputModel.armor);
        }
        //Bind to UI
        public void BindToModel(ContentPage page)
        {
            page.BindingContext = this;
            foreach (string key in attributes.Keys)
            {
                Binding bindingCurr = new Binding();
                bindingCurr.Path = "attributes[" + key + "].currValue";
                //cast object from FindByName to Label
                if (page.FindByName(key) == null) continue;
                ((Label)page.FindByName(key)).SetBinding(Label.TextProperty, bindingCurr);

                Binding bindingTop = new Binding();
                bindingTop.Path = "attributes[" + key + "].topValue";

                if (page.FindByName(key + "Top") == null) continue;
                ((Label)page.FindByName(key + "Top")).SetBinding(Label.TextProperty, bindingTop);
            }
            Binding weaponBinding = new Binding("weapon.name");
            ((Label)page.FindByName("weaponName")).SetBinding (Label.TextProperty, weaponBinding);

            weaponBinding = new Binding("weapon.attribute");
            ((Label)page.FindByName("weaponAttribute")).SetBinding (Label.TextProperty, weaponBinding);

            weaponBinding = new Binding("weapon.showAttack");
            ((Label)page.FindByName("weaponAttackBonus")).SetBinding (Label.TextProperty, weaponBinding);

            weaponBinding = new Binding("weapon.showDamage");
            ((Label)page.FindByName("weaponDamage")).SetBinding (Label.TextProperty, weaponBinding);

            Binding armorBinding = new Binding("armor.name");
            ((Label)page.FindByName("armorName")).SetBinding (Label.TextProperty, armorBinding);

            armorBinding = new Binding("armor.showBonus");
            ((Label)page.FindByName("armorBonus")).SetBinding (Label.TextProperty, armorBinding);

            armorBinding = new Binding("armor.showMaxDex");
            ((Label)page.FindByName("armorMaxDex")).SetBinding (Label.TextProperty, armorBinding);
        }
    }
}
