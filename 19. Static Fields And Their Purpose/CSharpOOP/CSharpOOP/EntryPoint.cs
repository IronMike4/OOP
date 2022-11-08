using System;
using System.Security.Claims;
using CSharpOOP.Characters.Warriors;

namespace CSharpOOP
{
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            Warrior firstWarrior = new Warrior();
            Console.WriteLine(Warrior.idCounter);

            Warrior secondWarrior = new Warrior(150, 50);
            Console.WriteLine(Warrior.idCounter);

            Warrior thirdWarrior = new Warrior(140, 80, "Third warrior");
            Console.WriteLine(Warrior.idCounter);


            //    Warrior theGoodGuy = new Warrior(190,80,"Batman");

            //    Warrior theBadGuy = new Warrior(170,94,"Joker");

            //    Warrior youngWarrior = new Warrior(150, 50);
            //    //youngWarrior.Age = 18;


            //    Console.WriteLine(youngWarrior.Age);


            //    Console.WriteLine(theBadGuy.Height);
            //    Console.WriteLine(theGoodGuy.Height);


            //    try
            //    {
            //        theGoodGuy.Age = 25;
            //        theBadGuy.Age = 15;
            //    }
            //    catch (ArgumentOutOfRangeException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //    Console.WriteLine(theGoodGuy.Age);
            //    Console.WriteLine(theBadGuy.Age);

            //    theGoodGuy.Greetings("Tod");

            //    Console.WriteLine(theGoodGuy.SwordWeapon.Damage);

        }
    }
}
