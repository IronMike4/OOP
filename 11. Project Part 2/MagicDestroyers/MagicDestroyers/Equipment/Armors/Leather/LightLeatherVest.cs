﻿using System;

namespace MagicDestroyers.Equipment.Armors.Leather
{
    public class LightLeatherVest
    {
        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                if (value >= 0)
                {
                    armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor Points value should be a positive number");
                }
            }
        }

        public LightLeatherVest()
        {

        }
    }
}
