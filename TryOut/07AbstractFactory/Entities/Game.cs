using System.Drawing;
using TryOut._07AbstractFactory.Entities;
using TryOut._07AbstractFactory.Interfaces;
using TryOut.Flyweight.StraightCode;

namespace TryOut.AbstractFactory.Entities {
    public class Game {

        public Game() {

            //Create human infantry

            IUnitFactory humanFactory = new HumanFactory();
            var infantry = humanFactory.CreateInfantry();
            infantry.Point = new Point(1,1);
            infantry.Draw();

            //Create protos rangers

            IUnitFactory protosFactory = new ProtosFactory();
            var rangers = protosFactory.CreateRangers();
            rangers.Point = new Point(2,3);
            rangers.Draw();

        }
    }
}