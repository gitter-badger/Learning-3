using Learning;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var decisionVariable = new DecisionVariable<string, int>(s => s.Length, 0, 50);
        }
    }
}
