using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryOut._07AbstractFactory.Interfaces;


namespace TryOut._07AbstractFactory.Entities
{
    public class ProtosFactory : IUnitFactory
    {
       
        public IInfantry CreateInfantry()
        {
            return new ProtosInfantry();
        }

        public IRangers CreateRangers()
        {
            return new ProtosRangers();
        }
    }
}
