using System;

namespace CSharpOOP
{
    public class Warrior
    {
        private int height;
        private int weight;

        public int Height { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }

        public void Greetings(Warrior warrior)
        {
            Console.WriteLine($@"Greetings, {warrior.Name}!");    
        }
    }

    public class EntryPoint
    {
        static void Main(string[] args)
        {
            Warrior theGoodGuy = new Warrior();
            theGoodGuy.Height = 190;
            theGoodGuy.Weight = 80;
            theGoodGuy.Name = "Batman";

            Warrior theBadGuy = new Warrior();
            theBadGuy.Height = 170;
            theBadGuy.Weight = 94;
            theBadGuy.Name = "Joker";

            Console.WriteLine(theBadGuy.Height);
            Console.WriteLine(theGoodGuy.Height);

            theGoodGuy.Greetings(theBadGuy);
            theBadGuy.Greetings(theGoodGuy);
        }
    }
}
