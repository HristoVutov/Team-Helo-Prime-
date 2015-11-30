using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeloPrimeRPG.Model.Characters
{
    using Interfaces;
    using Items;

    public abstract class Character : GameObject, IPosition
    {
        protected Character(string id, int x, int y, int health, int attack, int defense, int stamina, int range)
            : base(id)
        {
            this.X = x;
            this.Y = y;
            this.Health = health;
            this.Attack = attack;
            this.Defense = defense;
            this.Stamina = stamina;
            this.Range = range;
            this.IsAlive = true;
            this.Inventory = new List<Item>();
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Health { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public int Stamina { get; set; }

        public int Range { get; set; }

        public bool IsAlive { get; set; }

        public List<Item> Inventory { get; private set; }

        public void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        protected virtual void ApplyItemEffects(Item item)
        {
            
        }

        protected virtual void RemoveItemEffects(Item item)
        {
            
        }

    }
}
