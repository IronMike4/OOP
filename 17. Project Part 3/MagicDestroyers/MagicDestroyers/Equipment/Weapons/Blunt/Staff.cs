using System;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Staff
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

        public Staff()
        {

        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
