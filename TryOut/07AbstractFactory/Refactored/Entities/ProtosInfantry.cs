using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryOut._07AbstractFactory.Interfaces;
using TryOut.Flyweight.StraightCode;
using IInfantry = TryOut._07AbstractFactory.Interfaces.IInfantry;

namespace TryOut._07AbstractFactory.Entities
{
    public class ProtosInfantry : IInfantry
    {
        public int Armor { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public Point Point { get; set; }

        public ProtosInfantry()
        {
            Armor = 25;
            HP = 5;
            Attack = 15;
        }

        public void Draw()
        {
            var format = string.Format("{0}-{3} {1} {2}", nameof(ProtosInfantry), Point.X, Point.Y);
            Console.WriteLine(format);
        }
    }
}
