using Microsoft.Extensions.DependencyInjection;
using StructuralPatterns.Composite.Leaf;

namespace StructuralPatterns.Composite.Extensions;

// DI-Extension
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCompositeGraphic(this IServiceCollection services)
    {
        services.AddTransient<GraphicEditor>(sp =>
        {
            // Beispielhafte Struktur: Root -> (Circle, Rectangle, Group)
            Circle circle = new("K1");
            Rectangle rect = new("R1");
            Group group = new("G1");
            group.Add(new Circle("K2"));
            group.Add(new Rectangle("R2"));
            
            Group root = new("Root");
            root.Add(circle);
            root.Add(rect);
            root.Add(group);
            
            return new GraphicEditor(root);
        });
        
        return services;
    }
}