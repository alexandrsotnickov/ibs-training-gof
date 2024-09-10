using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOut._07AbstractFactory.Interfaces
{
    public interface IUnit
    {
        int Armor { get; set; }
        int HP { get; set; }
        int Attack { get; set; }
        Point Point { get; set; }
        void Draw();
    }
}
