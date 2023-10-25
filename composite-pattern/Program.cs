namespace composite_pattern;

internal class Program
{
    public static void Main(string[] args)
    {
        IGraphic graphic1 = new Dot(2, 3);
        IGraphic graphic2 = new Circle(4, 5, 10);
        IGraphic graphic3 = new Circle(-1, -9, 5);

        IGraphic compoundGraphic = new CompoundGraphic(new List<IGraphic> { graphic1, graphic2, graphic3 });
        compoundGraphic.Move(10, 100);
        compoundGraphic.Draw();
    }
}