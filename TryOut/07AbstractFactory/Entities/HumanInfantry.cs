using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryOut._07AbstractFactory.Interfaces;


namespace TryOut._07AbstractFactory.Entities
{
    public class HumanInfantry : IInfantry
    {
        public int Armor { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public Point Point { get; set; }
        public void Draw()
        {
            var format = string.Format("{0} {1} {2}", nameof(HumanInfantry), Point.X, Point.Y);
            Console.WriteLine(format);
        }

        public HumanInfantry()
        {
            Armor = 10;
            HP = 20;
            Attack = 5;
        }
    }
}
