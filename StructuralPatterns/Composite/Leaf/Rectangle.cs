using StructuralPatterns.Composite.Component;

namespace StructuralPatterns.Composite.Leaf;

// Leaf
public class Rectangle(string pName) : IGraphic
{
    private string Name { get; } = pName;
    
    public void Draw()
    {
        Console.WriteLine($"Zeichne Rechteck: {Name}");
    }
}