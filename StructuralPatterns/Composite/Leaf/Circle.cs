using StructuralPatterns.Composite.Component;

namespace StructuralPatterns.Composite.Leaf;

// Leaf
public class Circle(string pName) : IGraphic
{
    private string Name { get; } = pName;

    public void Draw()
    {
        Console.WriteLine($"Zeichne Kreis: {Name}");
    }
}