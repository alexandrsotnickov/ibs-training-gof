using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryOut.Flyweight.StraightCode;

namespace TryOut._07AbstractFactory.Interfaces
{
    public interface IUnitFactory
    {
        IInfantry CreateInfantry();
        IRangers CreateRangers();
    }
}
