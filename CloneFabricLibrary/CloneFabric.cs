using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneFabricLibrary
{
    internal class CloneFabric
    {
        public IWarrior CreateCloneWarrior(int num)
        {
            switch (num)
            {
                case 1: return new CloneWarior("Roman", "Defender");
                case 2: return new CloneWarior("Peter", "Bowman");
            }
            return null;
        }
    }
}
