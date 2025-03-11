using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KungligaRPG.Enums;

namespace KungligaRPG.Models
{
    public class Weapon
    {
        public string name { get; set; }
        public string attribute { get; set; }
        public Dice damageDice { get; set; }
        public string showStats { get; set; }

        public int attackBonus { get; set; }
        public int damageBonus { get; set; }
        public string showDamage { get; set; }

        public Weapon() { name = ""; attribute = ""; damageDice = Dice.dFour; }

        public Weapon(string name, string attribute, string damageDice)
        {
            this.name = name;
            this.attribute = attribute;
            this.damageDice = (Dice)int.Parse(damageDice);
            setShowStats();
        }

        public Weapon(Weapon source)
        {
            this.name = source.name;
            this.attribute = source.attribute;
            this.damageDice = source.damageDice;
            setShowStats();
        }

        public Weapon(Character self)
        {
            this.name = self.weapon.name;
            this.attribute = self.weapon.attribute;
            this.damageDice = self.weapon.damageDice;
            setShowStats();
            this.attackBonus = 2 + self.attributes[this.attribute.ToLower()].currValue;
            this.damageBonus = self.attributes[this.attribute.ToLower()].currValue;
            setDamage();
        }

        private void setShowStats()
        {
            showStats = "Name: " + name + "\nAttribute: " + attribute + "\nDamage Die: d" + (int)damageDice;
        }

        private void setDamage()
        {
            showDamage = "Damage: d" + (int)damageDice + " + " + damageBonus;
        }
    }
}
