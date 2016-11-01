using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRpgLib
{
    /// <summary>
    /// Super class for all player objects including:
    /// Hero, Monster and Non-combatants
    /// </summary>
    public class Player
    {
        public string Name;
        public int HitPoints;
        public int MagicPoints;
        public int AttackPoints;
        public int DefensePoints;
        public int Level;
        //public List<Spell> Spells;
        
        public int CalculateDamage(int min, int max, int bonus)
        {
            //TODO: STUB

            return 0;
        }

        //public List<Spells> GetSpells(){}

    }
}
