using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOut._08Composite.Refactored
{
    public interface IComposite
    {
        decimal Price { get; set; }
        decimal GetFullPrice();
        
          
    }
}
