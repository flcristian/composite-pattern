namespace composite_pattern;

public class Dot : IGraphic
{
    public int X { get; set; }
    public int Y { get; set; }

    public Dot(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(int x, int y)
    {
        this.X += x;
        this.Y += y;
    }

    public virtual void Draw()
    {
        Console.WriteLine($"DOT ({X}, {Y})");
    }
}