using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLib
{
    public class EVs
    {
        private Dictionary<Stat, int> dict;

        /// <summary>
        /// Default Contructor.
        /// Auto assign 0 to each stat
        /// </summary>
        public EVs()
        {
            dict = new Dictionary<Stat, int>();
            dict.Add(Stat.ATTACK, 0);
            dict.Add(Stat.DEFENSE, 0);
            dict.Add(Stat.SPATTACK, 0);
            dict.Add(Stat.SPDEFENSE, 0);
            dict.Add(Stat.SPEED, 0);
            dict.Add(Stat.HEALTH, 0);
        }
        
        /// <summary>
        /// Contruct a Ev set
        /// </summary>
        /// <param name="atk">Attack</param>
        /// <param name="def">Defense</param>
        /// <param name="spe">Speed</param>
        /// <param name="spa">SpAttack</param>
        /// <param name="spd">SpDefense</param>
        /// <param name="hp">Hit Point</param>
        public EVs(int atk, int def, int spe, int spa, int spd, int hp)
        {
            dict = new Dictionary<Stat, int>();
            dict.Add(Stat.ATTACK, atk);
            dict.Add(Stat.DEFENSE, def);
            dict.Add(Stat.SPATTACK, spa);
            dict.Add(Stat.SPDEFENSE, spd);
            dict.Add(Stat.SPEED, spe);
            dict.Add(Stat.HEALTH, hp);
        }
        
        /// <summary>
        /// Return stat value
        /// </summary>
        /// <param name="stat"></param>
        /// <returns></returns>
        public int GetEV(Stat stat)
        {
            return dict[stat];
        }

        /// <summary>
        /// Update value of stat
        /// </summary>
        /// <param name="stat"></param>
        /// <param name="newValue">New value of stat</param>
        public void EditEv(Stat stat, int newValue)
        {
            dict[stat] = newValue;
        }

    }
}
