using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryOut.Composite.Refactored;
using TryOut.Visitor.Straight;


namespace TryOut.Builder.Refactored
{
    public class CarBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            _car = new Car { Price = 1 };
        }

        public CarBuilder AddBody(decimal price)
        {
            var body = new Body { Price = price };
            _car.Add(body);
            return this;
        }

        public CarBuilder AddSalon(decimal price)
        {
            var salon = new Salon { Price = price };
            _car.Add(salon);
            return this;
        }

        public CarBuilder AddCockpit(decimal price)
        {
            var cockpit = new Cockpit { Price = price };
            _car.Add(cockpit);
            return this;
        }

        public CarBuilder AddAudio(decimal price)
        {
            var audio = new Audio { Price = price };
            audio.Add(new Reciever { Price = 1 });
            audio.Add(new Speakers { Price = 1 });
            _car.Add(audio);
            return this;
        }

        public CarBuilder AddEngine(decimal price)
        {
            var engine = new Engine { Price = price };
            engine.Add(new Turbo { Price = 1 });
            _car.Add(engine);
            return this;
        }

        public CarBuilder AddWheel(decimal price)
        {
            var wheel = new Wheel { Price = price };
            wheel.Add(new Disc { Price = 1 });
            wheel.Add(new Tire { Price = 1 });
            _car.Add(wheel);
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }
}
