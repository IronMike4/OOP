using System;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer
    {
        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 0)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage value should be a positive number");
                }
            }
        }

        public Hammer()
        {

        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
