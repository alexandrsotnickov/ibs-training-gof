using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryOut._07AbstractFactory.Interfaces;

namespace TryOut._07AbstractFactory.Entities
{
    public class HumanFactory : IUnitFactory
    {
       
        public IInfantry CreateInfantry()
        {
            return new HumanInfantry();
        }

        public IRangers CreateRangers()
        {
            return new HumanRangers();
        }
    }
}
