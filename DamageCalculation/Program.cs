using System;

namespace DamageCalculation
{
    class Program
    {
        static Random random = new Random();
        static WeaponDamage swordDamage = new SwordDamage(RollDice(3));
        static WeaponDamage arrowDamage = new ArrowDamage(RollDice(3));

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nS for sword, A for arrow, anything else to quit: ");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);
                switch (weaponKey)
                {
                    case 'S':
                        weaponSword();
                        break;
                    case 'A':
                        weaponArrow();
                        break;
                    default:
                        return;
                }
            }
        }

        /// <summary>
        /// Rolls dice x number of times.
        /// </summary>
        /// <returns>Returns result of x number of dice rolls.</returns>
        private static int RollDice(int numberOfRolls)
        {
            int i;
            int diceResult = 0;
            for (i = 1; i <= numberOfRolls; i++)
            {
                int diceRoll = random.Next(1, 7);
                diceResult += diceRoll;
            }
            return diceResult;
        }

        private static void weaponSword()
        {
            Console.Write("\n0 for no ability, 1 for magic, 2 for flaming, 3 for both, anything else to drop your weapon: ");
            string userInput = Console.ReadLine();
            if (userInput != "0" && userInput != "1" && userInput != "2" && userInput != "3")
            {
                Console.WriteLine("You dropped your weapon.");
                return;
            }

            swordDamage.Roll = RollDice(3);
            swordDamage.Magic = (userInput == "1" || userInput == "3");
            swordDamage.Flaming = (userInput == "2" || userInput == "3");

            Console.WriteLine($"Rolled {swordDamage.Roll} for {swordDamage.Damage} HP");
            Console.WriteLine("You dropped your weapon.");
        }

        private static void weaponArrow()
        {
            Console.Write("\n0 for no ability, 1 for magic, 2 for flaming, 3 for both, anything else to drop your weapon: ");
            string userInput = Console.ReadLine();
            if (userInput != "0" && userInput != "1" && userInput != "2" && userInput != "3")
            {
                Console.WriteLine("You dropped your weapon.");
                return;
            }

            arrowDamage.Roll = RollDice(3);
            arrowDamage.Magic = (userInput == "1" || userInput == "3");
            arrowDamage.Flaming = (userInput == "2" || userInput == "3");

            Console.WriteLine($"Rolled {arrowDamage.Roll} for {arrowDamage.Damage} HP");
            Console.WriteLine("You dropped your weapon.\n");
        }
    }
}
