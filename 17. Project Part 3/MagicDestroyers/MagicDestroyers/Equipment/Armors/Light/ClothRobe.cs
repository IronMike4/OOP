﻿using System;

namespace MagicDestroyers.Equipment.Armors.Light
{
    public class ClothRobe
    {
        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return this.armorPoints;
            }
            set
            {
                if (value >= 0)
                {
                    this.armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor Points value should be a positive number");
                }
            }
        }
        public ClothRobe()
        {

        }
    }
}
