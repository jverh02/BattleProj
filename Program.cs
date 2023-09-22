using Class05.Interfaces;
using Class05.Models;

namespace Class05
{
    class Program
    {
        static void Main(string[] args)
        {

            IArmor armor = new Leather("Elven Leather Armor", 12);
            IWeapon sword = new Sword("Long sword", 5);
            
            IArmor myArmor = new Adamantite();
            IWeapon myWeapon = new Battleaxe("Dwarven Battleaxe", 10);


            ICombatant fighter = new Fighter("Fighter Fred", armor, sword);
            ICombatant badGuy = new Fighter("Scary Monster", armor, sword);
            
            ICombatant myFighter = new Fighter("Smitty Werbenjaegermanjensen", myArmor, myWeapon);
            
            fighter.Attack(badGuy);

            myFighter.Attack(badGuy);
            badGuy.Attack(myFighter);

        }

    }

}
