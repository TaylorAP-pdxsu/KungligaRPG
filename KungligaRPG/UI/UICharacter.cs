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
        }

        //Convert all attributes to strings
        public void CopyCharacterToStrings(Character inputModel)
        {
            attributes = new SortedList<string, Models.Attribute>(inputModel.attributes);
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
        }
    }
}
