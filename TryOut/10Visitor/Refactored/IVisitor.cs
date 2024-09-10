namespace TryOut.Visitor.Refactored
{
    public interface IVisitor
    {
        void Visit(ICarPart visitor);
    }

}