using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungligaRPG.Models
{
    public class Character
    {
        public SortedList<string, KungligaRPG.Models.Attribute> attributes {  get; set; }
        public Armor armor { get; set; }
        //Primary attributes set to 0 values
        //Secondary attributes set to 0 values
        //Base attributes set to 10 *** Not yet implmented in character

        public Character()
        {
            armor = new Armor();
            attributes = new SortedList<string, Attribute>();
            attributes.Add("name", new TextAttribute("name", "New Character"));
            attributes.Add("physique", new PrimaryAttribute("physique", 0, 5));
            attributes.Add("dexterity", new PrimaryAttribute("dexterity", 0, 5));
            attributes.Add("mentality", new PrimaryAttribute("mentality", 0, 5));
            attributes.Add("charisma", new PrimaryAttribute("charisma", 0, 5));
            attributes.Add("health", new SecondaryAttribute("health", 10, 10));
            attributes.Add("energy", new SecondaryAttribute("energy", 4, 4));
            attributes.Add("actionPts", new SecondaryAttribute("actionPts", 2, 2));
            attributes.Add("defense", new BaseAttribute("defense", 10, 0));
            
        }

        public Character(Character source)
        {
            attributes = new SortedList<string, Attribute>(source.attributes);
            armor = new Armor(source.armor);
        }

        public interface IRetrieveData
        {
            public void RetrieveDataList(SortedList<string, Attribute> attributes);
        }

        public static int SetHealth(Enums.Dice dice, int phys)
        {
            Random random = new Random();
            return random.Next(1, (int)dice) + phys;
        }

        public static int SetArmor(Armor armor, int dex)
        {
            return armor.bonus + (dex > armor.maxDex ? armor.maxDex : dex);
        }

    }
}
