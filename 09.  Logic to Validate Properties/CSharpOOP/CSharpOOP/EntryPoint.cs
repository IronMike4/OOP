using System;
using CSharpOOP.Characters.Warriors;

namespace CSharpOOP
{
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            Warrior theGoodGuy = new Warrior(190,80,"Batman");

            Warrior theBadGuy = new Warrior(170,94,"Joker");
            
            Console.WriteLine(theBadGuy.Height);
            Console.WriteLine(theGoodGuy.Height);

            theGoodGuy.Age = 25;
            theBadGuy.Age = 15;

            Console.WriteLine(theGoodGuy.Age);
            Console.WriteLine(theBadGuy.Age);
             
            theGoodGuy.Greetings(theBadGuy);
            theBadGuy.Greetings(theGoodGuy);
        }
    }
}
