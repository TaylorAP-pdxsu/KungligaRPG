using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KungligaRPG.Models
{
    public class Armor
    {
        public string name { get; set; }
        public int bonus { get; set; }
        public string showBonus {  get; set; }

        public int maxDex { get; set; }
        public string showMaxDex {  get; set; }

        public string showStats { get; set; }

        public Armor() { name = "";  bonus = 0; maxDex = 0; }

        public Armor(string name, int bonus, int maxDex)
        {
            this.name = name;
            this.bonus = bonus;
            this.maxDex = maxDex;
            setShowStats();
        }

        public Armor(Armor source)
        {
            this.name = source.name;
            this.bonus = source.bonus;
            this.maxDex = source.maxDex;
            setShowStats();
            setBonus();
            setMaxDex();
        }

        private void setShowStats()
        {
            showStats = "Name: " + name + "\nBonus: " + bonus + "\nMax Dex: " + maxDex;
        }

        private void setBonus()
        {
            showBonus = "Bonus: " + bonus;
        }

        private void setMaxDex()
        {
            showMaxDex = "Max Dex: " + maxDex;
        }
    }
}
