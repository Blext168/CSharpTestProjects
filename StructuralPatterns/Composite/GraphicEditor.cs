using StructuralPatterns.Composite.Component;

namespace StructuralPatterns.Composite;

public class GraphicEditor(IGraphic pRoot)
{
    public void Render()
    {
        Console.WriteLine("Starte Rendering...");
        pRoot.Draw();
    }
}