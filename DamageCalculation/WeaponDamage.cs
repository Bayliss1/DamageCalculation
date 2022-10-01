using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCalculation
{
    class WeaponDamage
    {
        // property for damage
        public int Damage { get; private set; }

        // roll backing field and property
        protected int roll;
        public int Roll
        { 
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        // flaming backing field and property
        protected int flaming;
        public int Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        // magic backing field and property
        protected int magic;
        public int Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        protected virtual void CalculateDamage()
        {
            /*subclasses override this*/
        }

        /// <summary>
        /// Constructor calculates damage based on default Magic and Flaming values and a starting 3d6 roll.
        /// </summary>
        /// <param name="startingRoll">Starting 3d6 roll</param>
        public WeaponDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }
    }
}
