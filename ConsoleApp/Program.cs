using System.Data;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace ConsoleApp
{
    public sealed class Program()
    {

        static async Task Main(string[] args)
        {
            string test = Enum.ToObject(typeof(SampleEnum), 2).ToString() ?? string.Empty;
            Console.WriteLine("EnumValue: " + test);
            
            var result = new DataTable().Compute("5+5", null);
            int finalValue = Convert.ToInt32(result); // Ergibt 10
            Console.WriteLine(finalValue);
            
            var ergebnis = await CSharpScript.EvaluateAsync<double>("1 + 2 * 3");
            Console.WriteLine(ergebnis);
        }
    }
}
