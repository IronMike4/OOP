using System;

namespace CSharpOOP
{
    public class Warrior
    {
        private int height;
        private int weight;
        private string name;

        public int Height { get; set; }
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

    public class EntryPoint
    {
        static void Main(string[] args)
        {
            Warrior theGoodGuy = new Warrior(190,80,"Batman");

            Warrior theBadGuy = new Warrior(170,94,"Joker");
            
            Console.WriteLine(theBadGuy.Height);
            Console.WriteLine(theGoodGuy.Height);

            theGoodGuy.Greetings(theBadGuy);
            theBadGuy.Greetings(theGoodGuy);
        }
    }
}
