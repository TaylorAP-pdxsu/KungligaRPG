using KungligaRPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungligaRPG.UI
{
    internal class UICreator : Character.IRetrieveData
    {
        ContentPage page;

        public UICreator(ContentPage page)
        {
            this.page = page;
        }

        public void RetrieveDataList(SortedList<string, Models.Attribute> attributes)
        {
            FindAndSet("name", attributes);
            FindAndSet("physique", attributes);
            FindAndSet("dexterity", attributes);
            FindAndSet("mentality", attributes);
            FindAndSet("charisma", attributes);
        }

        public void FindAndSet(string key, SortedList<string, Models.Attribute> attributes)
        {
            attributes[key].setValue(page.FindByName(key) == null ? 0 : ((Entry)page.FindByName(key)).Text);
        }
    }
}
