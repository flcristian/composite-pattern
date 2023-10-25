namespace composite_pattern;

public class CompoundGraphic : IGraphic
{
    public List<IGraphic> Children { get; set; }

    public CompoundGraphic(List<IGraphic> children)
    {
        this.Children = children;
    }

    public void Move(int x, int y)
    {
        foreach (IGraphic child in Children)
        {
            child.Move(x, y);
        }
    }

    public void Draw()
    {
        foreach (IGraphic child in Children)
        {
            child.Draw();
        }
    }
}