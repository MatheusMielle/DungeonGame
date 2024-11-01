﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Project
{
    public abstract class Items
    {
        protected string name { get; init; } // name of the item
        protected string description { get; init; } // description of the item
        protected int powerLvl { get; init; }   //level of power of the item

        public string getName() { return name; }
        public string getDescription() { return description; }
        public int getPowerLvl() { return powerLvl; }

        public abstract void DoAction(Player p); //Execute what the item is supposed to do
        public virtual void ReverseAction(Player p) //Reverse the action the item did. 
        {
            Console.WriteLine("Sorry, action can't be reversed!");
        }

    }

    public class Key : Items
    {
        public Key(string name, string description)
        {
            this.name = name;
            this.description = description;
            powerLvl = 0;
        }
        public override void DoAction(Player p)
        {
            p.Unlock();
        }
    }

    public class Sword : Items 
    {
        public Sword(string name, string description, int powerLvl)
        {
            this.name = name;
            this.description = description;
            this.powerLvl = powerLvl;
        }
        public override void DoAction(Player p)
        {
            int newStrength = p.getStrengthPoints() + powerLvl;
            p.UpdateStatus(newStrength, 'S');
        }
        public override void ReverseAction(Player p)
        {
            int newStrength = p.getStrengthPoints() - powerLvl;
            p.UpdateStatus(newStrength, 'S');

        }
    }

    public abstract class Armor : Items
    {
        public Armor(string name, string description, int powerLvl)
        {
            this.name = name;
            this.description = description;
            this.powerLvl = powerLvl;
        }
        public override void DoAction(Player p)
        {
            int newStrength = p.getDefensePoints() + powerLvl;
            p.UpdateStatus(newStrength, 'D');
        }
        public override void ReverseAction(Player p)
        {
            int newStrength = p.getDefensePoints() - powerLvl;
            p.UpdateStatus(newStrength, 'D');
        }
    }

    public class ChestPlate : Armor
    {
        public ChestPlate(string name, string description, int powerLvl)
            : base(name, description, powerLvl) { }
    }
    public class Helmet : Armor
    {
        public Helmet(string name, string description, int powerLvl)
            : base(name, description, powerLvl) { }
    }
    public class Leggings : Armor
    {
        public Leggings(string name, string description, int powerLvl)
            : base(name, description, powerLvl) { }
    }
    public class Boots : Armor
    {
        public Boots(string name, string description, int powerLvl)
            : base(name, description, powerLvl) { }
    }
    public class Shield: Armor
    {
        public Shield(string name, string description, int powerLvl)
            : base(name, description, powerLvl) { }
    }

    public abstract class Potion : Items
    {
        public Potion(string name, string description, int powerLvl)
        {
            this.name = name;
            this.description = description;
            this.powerLvl = powerLvl;
        }
        public override abstract void DoAction(Player p);
        public override abstract void ReverseAction(Player p);

    }

    public class HealthPotion : Potion
    {
        public HealthPotion(string name, string description, int powerLvl)
            : base(name, description, powerLvl) { }

        public override void DoAction(Player p)
        {
            int newStrength = p.getHealthPoints() + powerLvl;
            p.UpdateStatus(newStrength, 'H');
        }
        public override void ReverseAction(Player p)
        {
            int newStrength = p.getHealthPoints() - powerLvl;
            p.UpdateStatus(newStrength, 'H');
        }

    }
    public class StrengthPotion : Potion
    {
        public StrengthPotion(string name, string description, int powerLvl)
            : base(name, description, powerLvl) { }

        public override void DoAction(Player p)
        {
            int newStrength = p.getStrengthPoints() + powerLvl;
            p.UpdateStatus(newStrength, 'S');
        }
        public override void ReverseAction(Player p)
        {
            int newStrength = p.getStrengthPoints() - powerLvl;
            p.UpdateStatus(newStrength, 'S');
        }
    }



}
