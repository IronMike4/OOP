using System;

namespace CSharpOOP.Characters.Warriors
{
    public class Warrior
    {
        private int height;
        private int weight;
        private string name;

        public int Height 
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }

        }
        public int Weight { get; set; }
        public string Name { get; set; }

        public void Greetings(Warrior warrior)
        {
            Console.WriteLine($@"Greetings, {warrior.Name}!");
        }

        public Warrior(int height, int weight, string name)
        {
            Height = height;
            Weight = weight;
            Name = name;
        }
    }
}