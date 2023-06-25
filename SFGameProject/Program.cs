using System.IO.Pipes;

namespace SFGameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunEngine run = new RunEngine();
            run.Run();

        }
    }
}