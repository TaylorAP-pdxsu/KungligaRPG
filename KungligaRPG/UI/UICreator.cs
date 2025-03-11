using KungligaRPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace KungligaRPG.UI
{
    public partial class UICreator : Character.IRetrieveData, INotifyPropertyChanged
    {
        ContentPage? page;
        public ObservableCollection<Armor>? armors {  get; set; }
        public ObservableCollection<Weapon>? weapons { get; set; }

        private Armor? _selectedArmor;
        public Armor? SelectedArmor
        {
            get => _selectedArmor;
            set
            {
                if (_selectedArmor != value)
                {
                    _selectedArmor = value;
                    OnPropertyChanged(nameof(SelectedArmor));
                }
            }
        }

        private Weapon? _selectedWeapon;
        public Weapon? SelectedWeapon
        {
            get => _selectedWeapon;
            set
            {
                if (_selectedWeapon != value)
                {
                    _selectedWeapon = value;
                    OnPropertyChanged(nameof(SelectedWeapon));
                }
            }
        }

        public UICreator() { }

        public UICreator(ContentPage page)
        {
            this.page = page;
            armors = new ObservableCollection<Armor>()
            {
                new Armor("Leather", 1, 0),
                new Armor("Chain", 2, 0),
                new Armor("Plate", 3, 0)
            };
            weapons = new ObservableCollection<Weapon>()
            {
                new Weapon("Longsword", "physique", "8"),
                new Weapon("Shortsword", "dexterity", "6"),
                new Weapon("Greataxe", "physique", "12")
            };
        }

        public void RetrieveDataList(Character character)
        {
            FindAndSet("name", character.attributes);
            FindAndSet("physique", character.attributes);
            FindAndSet("dexterity", character.attributes);
            FindAndSet("mentality", character.attributes);
            FindAndSet("charisma", character.attributes);
            character.attributes["health"].setValue(
                        Character.SetHealth((Enums.Dice)(int.Parse((string)(((Picker)page.FindByName("healthDie")).SelectedItem)))
                                    , character.attributes["physique"].currValue)
                        );
            //attributes["defense"].setValue(Character.SetArmor())
            character.armor = new Armor(SelectedArmor);
            character.weapon = new Weapon(SelectedWeapon);
        }

        public void FindAndSet(string key, SortedList<string, Models.Attribute> attributes)
        {
            attributes[key].setValue(page.FindByName(key) == null ? 0 : ((Entry)page.FindByName(key)).Text);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void addArmorToList()
        {
            armors.Add(new Armor(
                    ((Entry)page.FindByName("armorName")).Text,
                    int.Parse(((Entry)page.FindByName("armorBonus")).Text),
                    int.Parse(((Entry)page.FindByName("armorMaxDex")).Text)
                ));
            OnPropertyChanged(nameof(armors));
        }

        public void addWeaponToList()
        {
            weapons.Add(new Weapon(
                    ((Entry)page.FindByName("weaponName")).Text,
                    (string)((Picker)page.FindByName("weaponAttribute")).SelectedItem,
                    (string)((Picker)page.FindByName("weaponDie")).SelectedItem
                ));
        }

    }       
}
