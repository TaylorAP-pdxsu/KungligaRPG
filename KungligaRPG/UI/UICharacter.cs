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

        public UICharacter() {
            attributes = new SortedList<string, Models.Attribute>();
            //attributes.Add("name", ("New Character", null));
            //attributes.Add("physique", ("0", "0"));
            //attributes.Add("dexterity", ("0", "0"));
            //attributes.Add("mentality", ("0", "0"));
            //attributes.Add("charisma", ("0", "0"));
            //attributes.Add("currHealth", ("1", "1"));
            //attributes.Add("currEnergy", ("0", "0"));
            //attributes.Add("currActionPts", ("2", "2"));
        }

        //Convert all attributes to strings
        public void CopyCharacterToStrings(Character inputModel)
        {
            attributes = new SortedList<string, Models.Attribute>(inputModel.attributes);
            //foreach (string key in inputModel.attributes.Keys)
            //{
            //    attributes[key] = inputModel.attributes[key].gettuple();
            //}
        }
        //Bind to UI
        public void BindToModel(ContentPage page)
        {

            //Binding binding1 = new Binding();
            //binding1.Source = this;
            //binding1.Path = "attributes[" + "name" + "].currValue";
            ////cast object from FindByName to Label
            //((Label)page.FindByName("name")).SetBinding(Label.TextProperty, binding1);
            page.BindingContext = this;
            foreach (string key in attributes.Keys)
            {
                Binding binding1 = new Binding();
                binding1.Path = "attributes[" + key + "].currValue";
                //if (((Label)page.FindByName(key)) == null) continue;
                //cast object from FindByName to Label
                ((Label)page.FindByName(key)).SetBinding(Label.TextProperty, binding1);
            }
        }
    }
}
