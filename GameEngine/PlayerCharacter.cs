using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class PlayerCharacter
    {
        public int Health { get; set; } = 100;
        public bool IsNoob { get; set; } = true;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string NickName { get; set; }
        public List<string> Weapons { get; set; }

        public PlayerCharacter()
        {
            GenerateWeapons();
        }
        public void sleep()
        {
            
            var calculateHealthIncrease = CalculateHealthIncrease();
            Health += calculateHealthIncrease;
        }

        private void GenerateWeapons() {
            Weapons = new List<string> { "Pistol", "Rifle", "Guns", "Bomb" };
        }

        private int CalculateHealthIncrease() {

            var randomnumber = new Random();
            return randomnumber.Next(1, 101);
        }

        public void CalcualteDamage(int inputdamage) {
            Health = inputdamage + Health;
        }
    
    }
}
