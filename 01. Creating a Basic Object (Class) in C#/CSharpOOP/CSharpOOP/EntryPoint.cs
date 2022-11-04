using System;

namespace CSharpOOP
{
    public class Warrior
    {
        public int height;
        public int weight;
    }

    public class EntryPoint
    {
        static void Main(string[] args)
        {
            Warrior theGoodGuy = new Warrior();
            theGoodGuy.height = 190;
            theGoodGuy.weight = 80;

            Warrior theBadGuy = new Warrior();
            theBadGuy.height = 170;
            theBadGuy.weight = 94;

            Console.WriteLine(theBadGuy.height);
            Console.WriteLine(theGoodGuy.height);
        }
    }
}
