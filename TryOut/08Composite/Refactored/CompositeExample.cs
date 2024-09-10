namespace TryOut.Composite.Refactored {
    // Пример использования композиции
    public class CompositeExample
    {
        public CompositeExample()
        {
            var car = CreateCar();
            var fullPrice = car.GetFullPrice();
            Console.WriteLine($"Full car price: {fullPrice}");
        }

        private Car CreateCar()
        {
            var car = new Car
            {
                Body = new Body
                {
                    Price = 1,
                    ColorType = new ColorType { Price = 1 },
                    Salon = new Salon
                    {
                        Price = 1,
                        Cockpit = new Cockpit
                        {
                            Price = 1,
                            Audio = new Audio
                            {
                                Price = 1,
                                Reciever = new Reciever { Price = 1 },
                                Speakers = new Speakers { Price = 1 }
                            }
                        }
                    }
                },
                Engine = new Engine
                {
                    Price = 1,
                    Turbo = new Turbo { Price = 1 }
                },
                Price = 1,
                Wheels = new List<Wheel> {
                    new Wheel { Price = 1, Disc = new Disc { Price = 1 }, Tire = new Tire { Price = 1 } },
                    new Wheel { Price = 1, Disc = new Disc { Price = 1 }, Tire = new Tire { Price = 1 } },
                    new Wheel { Price = 1, Disc = new Disc { Price = 1 }, Tire = new Tire { Price = 1 } },
                    new Wheel { Price = 1, Disc = new Disc { Price = 1 }, Tire = new Tire { Price = 1 } }
                }
            };

            return car;
        }
    }
}