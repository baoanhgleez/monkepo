using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLib
{
    public class Contruct
    {
        public String Spec { get; set; }
        public String Item { get; set;  }
        public String Ability { get; set; }
        public EVs EVs { get; set; }
        public String Nature { get; set; }
        public MoveSet MoveSet { get; set; }

        public Contruct(String spec, String item, String abi, String nature)
        {
            Spec = spec;
            Item = item;
            Ability = abi;
            Nature = nature;

            this.EVs = new EVs();
            this.MoveSet = new MoveSet();
        }
        
    }
}
