using System;
using Weapons;

namespace CSharpOOP.Characters.Warriors
{
    public class Warrior
    {
        private int height;
        private int weight;
        private int age;
        private string name;
        private Sword swordWeapon;

        protected internal int Height
        {
            get
            {
                return height;
            }
            private set
            {
                height = value;
            }

        }
        public int Weight { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 18 && value <= 45)
                {
                    age = value;

                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The selected age for {name}, is not a proper age for a Warrior.The age must be between 18 and 45.");
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Sword SwordWeapon
        {
            get
            {
                return this.swordWeapon;
            }
            set
            {
                this.swordWeapon = value;
            }
        }

        public void Greetings(string name)
        {
            Console.WriteLine($@"{this.name}, greets {name}!");
        }

        public Warrior()
        : this(170, 70)
        {
        }

        public Warrior(int height, int weight)
        :this(height,weight,"Young Warrior")
        {
        }

        public Warrior(int height, int weight, string name)
        {
            this.height = height;
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
            this.Age = 18;
            this.SwordWeapon = new Sword();
        }
    }
}