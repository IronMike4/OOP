using System;

namespace MagicDestroyers.Equipment.Sharp
{
    public class Axe
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

        public Axe()
        {

        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
