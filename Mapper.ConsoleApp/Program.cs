using BenchmarkDotNet.Running;

namespace Mapper.ConsoleApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            _ = BenchmarkRunner.Run<TestBenchmark>();
        }
    }
}