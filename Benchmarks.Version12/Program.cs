using static BenchmarkDotNet.Running.BenchmarkRunner;
using static System.Console;

namespace Benchmarks.Version12
{
    public static class Program
    {
        public static void Main(string[] args = default)
        {
            WriteLine("Running tests for version 12.4.7");
            Run<Tests>();
        }
    }
}
