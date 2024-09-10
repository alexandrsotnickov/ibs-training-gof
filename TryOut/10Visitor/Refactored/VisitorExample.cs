namespace TryOut.Visitor.Refactored
{
    public class VisitorExample {
        public VisitorExample()
        {
            var car = CreateCar();
          
            var priceModifier = new Visitor(1.2m);
            car.Accept(priceModifier);

            var newFullPrice = car.GetFullPrice();
            Console.WriteLine("Full price: " + newFullPrice);
        }

        private Car CreateCar() {
            var car = new Car{Price = 1};
            var body = new Body {Price = 1};
            body.Add(new ColorType {Price = 1});
            var salon = new Salon {Price = 1};
            var cockpit = new Cockpit {Price = 1};
            var audio = new Audio {Price = 1};
            audio.Add(new Reciever {Price = 1});
            audio.Add(new Speakers {Price = 1});
           
            cockpit.Add(audio);
            salon.Add(cockpit);
            body.Add(salon);

            car.Add(body);

            var engine = new Engine {Price = 1};
            engine.Add(new Turbo {Price = 1});
            car.Add(engine);

            var wheel = new Wheel {Price = 1};
            wheel.Add(new Disc {Price = 1});
            wheel.Add(new Tire {Price = 1});
            car.Add(wheel);

            wheel = new Wheel {Price = 1};
            wheel.Add(new Disc {Price = 1});
            wheel.Add(new Tire {Price = 1});
            car.Add(wheel);

            wheel = new Wheel {Price = 1};
            wheel.Add(new Disc {Price = 1});
            wheel.Add(new Tire {Price = 1});
            car.Add(wheel);

            wheel = new Wheel {Price = 1};
            wheel.Add(new Disc {Price = 1});
            wheel.Add(new Tire {Price = 1});
            car.Add(wheel);


            return car;
        }
    }
}