using System.Collections.ObjectModel;

namespace TryOut.Visitor.Refactored {
    public interface ICarPart {
        decimal Price { get; set; }
        decimal GetFullPrice();
        void Accept(IVisitor visitor);
    }

    public abstract class CompositeNode : ICarPart {
        private readonly List<ICarPart> carParts;

        public ReadOnlyCollection<ICarPart> Parts {
            get {
                return carParts.AsReadOnly();
            }
        } 

        protected CompositeNode() {
            carParts = new List<ICarPart>();
        }

        public void Add(ICarPart carPart) {
            if (CanAddPart()) {
                carParts.Add(carPart);
            }
        }

        public virtual bool CanAddPart() {
            return true;
        }

        public decimal Price { get; set; }

        public decimal GetFullPrice() {
            return carParts.Sum(i => i.GetFullPrice()) + Price;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            carParts.ForEach(i  => i.Accept(visitor));
        }
    }

    public abstract class Node : ICarPart {
        public decimal Price { get; set; }
        private readonly List<ICarPart> nodes;
        protected Node()
        {
            nodes = new List<ICarPart>();
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            nodes.ForEach(i => i.Accept(visitor));
        }

        public decimal GetFullPrice() {
            return Price;
        }
    }

    public class Car : CompositeNode {}

    public class Body : CompositeNode {}

    public class Salon : CompositeNode {}

    public class Cockpit : CompositeNode {}

    public class Audio : CompositeNode {}

    public class Reciever : Node {}

    public class Speakers : Node {}

    public class Wheel : CompositeNode {}

    public class Engine : CompositeNode {}

    public class ColorType : Node {}

    public class Tire : Node {}

    public class Disc : Node {}

    public class Turbo : Node {}
}