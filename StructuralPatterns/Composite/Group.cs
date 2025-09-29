using StructuralPatterns.Composite.Component;

namespace StructuralPatterns.Composite;

// Composite
public class Group(string pName) : IGraphic
{
    private string Name { get; } = pName;
    private readonly List<IGraphic> _childrens = new();
    
    public void Add(IGraphic pGraphic) => _childrens.Add(pGraphic);
    
    public void Remove(IGraphic pGraphic) => _childrens.Remove(pGraphic);
    
    public void Draw()
    {
        Console.WriteLine($"Gruppe {Name} enthält:");
        foreach (var child in _childrens)
            child.Draw();
    }
}