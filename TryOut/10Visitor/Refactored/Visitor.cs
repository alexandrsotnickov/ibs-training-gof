using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryOut.Visitor.Refactored;

namespace TryOut.Visitor.Refactored
{
    public class Visitor : IVisitor
    {
        private readonly decimal _multiplier;

        public Visitor(decimal multiplier)
        {
            _multiplier = multiplier;
        }

        public void Visit(ICarPart part)
        {
            part.Price *= _multiplier;
        }

    }
}
