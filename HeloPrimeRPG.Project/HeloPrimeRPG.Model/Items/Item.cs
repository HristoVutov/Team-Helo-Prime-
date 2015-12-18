
namespace HeloPrimeRPG.Model.Items
{
    public abstract class Item
    {
        private string weapon;
        private string armor;

        public Item(string weapon, string armor)
        {
            this.Weapon = weapon;
            this.Armor = armor;
        }

        public string Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }
        public string Armor
        {
            get { return this.armor; }
            set { this.armor = value; }
        }
    }
}
