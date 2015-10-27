using System;
using System.Diagnostics;
using System.Threading;
using System.Runtime.CompilerServices;
using BenchmarkDotNet;
using BenchmarkDotNet.Tasks;
using DynamicComparer.Benchmark;
using System;



namespace BenchmarkDotNet.Autogenerated
{
    public class Program : DynamicComparer.Benchmark.ComplexComparisonTest
    {
        public static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine(BenchmarkDotNet.EnvironmentHelper.GetFullEnvironmentInfo());
                Program instance = new Program();
                var settings = BenchmarkSettings.Parse(args);
                
                instance.RunBenchmark(settings);
                System.Console.WriteLine("// Benchmark finished");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                throw;
            }
        }

        public Program()
        {
            setupAction = () => { };
            idleAction = Idle;
            targetAction = DynamicCodeCompare;
        }

        
        private Action setupAction;
        private Action  targetAction, idleAction;

        public void RunBenchmark(BenchmarkSettings settings)
        {
            new BenchmarkMethodInvoker().Throughput(settings, 1, setupAction, targetAction, idleAction);
        }


        private void Idle()
        {
            
        }
    }
}
