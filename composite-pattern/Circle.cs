namespace composite_pattern;

public class Circle : Dot
{
    public int Radius { get; set; }

    public Circle(int x, int y, int radius) : base(x, y)
    {
        this.Radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"CIRCLE ({X}, {Y}), RADIUS = {Radius}");
    }
}