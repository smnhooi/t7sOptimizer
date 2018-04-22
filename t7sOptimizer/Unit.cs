using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t7sOptimizer
{
    class Unit
    {
        int maxMember=9;
        List<IdolInstance> idols;
        public Unit(int maxMember)
        {
            idols = new List<IdolInstance>(maxMember);
            for(int i = 0; i < idols.Count; i++)
            {
                idols[i] = new IdolInstance();
            }
            
        }

    }
}
