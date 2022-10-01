using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCalculation
{
    class ArrowDamage : WeaponDamage
    {
        public const decimal BASE_MULTIPLIER = 0.35M;
        public const decimal MAGIC_MULTIPLIER = 2.5M;
        public const decimal FLAME_DAMAGE = 1.25M;

        /// <summary>
        /// Calculates the damage based on the current properties.
        /// </summary>
        protected override void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
        }

        /// <summary>
        /// Constructor calculates damage based on default Magic and Flaming values and a starting 3d6 roll.
        /// </summary>
        /// <param name="startingRoll">Starting 3d6 roll</param>
        public ArrowDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }
    }
}
