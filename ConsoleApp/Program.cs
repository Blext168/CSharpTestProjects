namespace ConsoleApp
{
    public sealed class Program()
    {

        static void Main(string[] args)
        {
            string test = Enum.ToObject(typeof(SampleEnum), 2).ToString() ?? string.Empty;
            Console.WriteLine("EnumValue: " + test);
        }
    }
}
