using static BenchmarkDotNet.Running.BenchmarkRunner;
using static System.Console;

namespace Benchmarks.Version13
{
    public static class Program
    {
        public static void Main(string[] args = default)
        {
            WriteLine("Running tests for version 13.0.2");
            Run<Tests>();
        }
    }
}
