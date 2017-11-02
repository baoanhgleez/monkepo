using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLib
{
    public class MoveSet
    {
        private List<Move> MoveList;

        public MoveSet()
        {
            MoveList = new List<Move>(4);
        }

        /// <summary>
        /// Add a move to move set.
        /// </summary>
        /// <param name="move"></param>
        /// <returns></returns>
        public int AddMove(Move move)
        {
            MoveList.Add(move);
            return MoveList.Count;
        }

        /// <summary>
        /// If MOVESET didn't have enough 4 move, it will return NULL.
        /// </summary>
        /// <returns>Return move list</returns>
        public List<Move> GetAll()
        {
            return (MoveList.Count < 4) ? null : MoveList;
        }
    }
}
