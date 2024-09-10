using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryOut._07AbstractFactory.Interfaces;

namespace TryOut._07AbstractFactory.Entities
{
    public class ZergInfantry : IInfantry
    {
        public int Armor { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public Point Point { get; set; }

        public ZergInfantry()
        {
            Armor = 5;
            HP = 25;
            Attack = 10;
        }

        public void Draw()
        {
            var format = string.Format("{0}-{3} {1} {2}", nameof(ZergInfantry), Point.X, Point.Y);
            Console.WriteLine(format);
        }
    }
}
