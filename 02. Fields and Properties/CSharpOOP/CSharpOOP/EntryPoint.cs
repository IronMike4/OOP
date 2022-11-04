using System;

namespace CSharpOOP
{
    public class Warrior
    {
        private int height;
        private int weight;

        public int Height { get; set; }
        public int Weight { get; set; }
    }

    public class EntryPoint
    {
        static void Main(string[] args)
        {
            Warrior theGoodGuy = new Warrior();
            theGoodGuy.Height = 190;
            theGoodGuy.Weight = 80;

            Warrior theBadGuy = new Warrior();
            theBadGuy.Height = 170;
            theBadGuy.Weight = 94;

            Console.WriteLine(theBadGuy.Height);
            Console.WriteLine(theGoodGuy.Height);
        }
    }
}
