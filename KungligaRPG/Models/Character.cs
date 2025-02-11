using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungligaRPG.Models
{
    public class Character
    {
        public string name { get; set; }

        //Primary attributes set to 0 values
        public Attribute physique { get; set; }
        public Attribute dexterity { get; set; }
        public Attribute mentality { get; set; }
        public Attribute charisma { get; set; }

        //Secondary attributes set to 0 values
        public SecondaryAttribute health { get; set; }
        public SecondaryAttribute energy { get; set; }
        public SecondaryAttribute actionPts { get; set; }
        public SecondaryAttribute speed { get; set; }
        public SecondaryAttribute initiativeBonus { get; set; }

        //Base attributes set to 10
        public BaseAttribute defense { get; set; }
        public BaseAttribute physResistance { get; set; }
        public BaseAttribute dexResistance { get; set; }
        public BaseAttribute menResistance { get; set; }
        public BaseAttribute chaResistance { get; set; }

        //public String size; need to consider how to handle

        public Character()
        { 
            name            = new string("Kungen");

            physique        = new PrimaryAttribute("Physique", 0, 5);
            dexterity       = new PrimaryAttribute("Dexterity", 0, 5);
            mentality       = new PrimaryAttribute("Mentality", 0, 5);
            charisma        = new PrimaryAttribute("Charisma", 0, 5);

            health          = new SecondaryAttribute("Health", 10, 10);
            energy          = new SecondaryAttribute("Energy", 10, 10);
            actionPts       = new SecondaryAttribute("Actions", 2, 2);
            speed           = new SecondaryAttribute("Speed", 6, 6);
            initiativeBonus = new SecondaryAttribute("Initiative", 0, 0);

            defense         = new BaseAttribute("Defense", 10, 0);
            physResistance  = new BaseAttribute("Physique Resistance", 10, 0);
            dexResistance   = new BaseAttribute("Dexterity Resistance", 10, 0);
            menResistance   = new BaseAttribute("Mentality Resistance", 10, 0);
            chaResistance   = new BaseAttribute("Charisma Resistance", 10, 0);
        }

    }
}
