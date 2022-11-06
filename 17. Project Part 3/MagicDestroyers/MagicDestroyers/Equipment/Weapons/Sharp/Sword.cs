using System;

namespace MagicDestroyers.Equipment.Sharp
{
    public class Sword
    {
        private int damage;

        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value >= 0)
                {
                    this.damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage value should be a positive number");
                }
            }
        }

        public Sword()
        {

        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
